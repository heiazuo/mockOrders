using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Bogus;
using ErpDataFactory.Log;
using ErpDataFactory.setting;
using Newtonsoft.Json;

namespace ErpDataFactory
{
    internal class Program
    {
        private static readonly string PathUrl = Environment.CurrentDirectory + "\\setting.json";

        private static readonly int OrdersFactoryTaskNum = 100; //线程任务数  
        private static readonly int SaleFactoryTaskNum = 10; //线程任务数

        private static void Main(string[] args)
        {
            var setting = JsonConvert.DeserializeObject<setting.setting>(File.ReadAllText(PathUrl));

            if (setting == null)
            {
                Console.WriteLine("没有配置文件");
                return;
            }

            var dbContext = new ErpDataBase();
            var goodsList = dbContext.Goods.Where(p => p.IsEnable && (p.BranchId == setting.BranchId || p.BranchId == 1)).OrderByDescending(e => e.SaleNumber).Take(3000).ToList();
            var userList = dbContext.View_Sys_Users.Where(p => p.BranchId == setting.BranchId).Where(p => p.DeptName.Contains("大客户销售事业部") || p.DeptName.Contains("总经办")).Select(p => p.Id).ToList();
            var salesList = dbContext.View_Sys_Users.Where(p => p.BranchId == setting.BranchId).Where(e => e.IsSales).Select(p => p.Id).ToList();
            var memberList = dbContext.View_Member.Where(p => p.CustomerId > 0 && p.DeptId > 0 && p.BranchId == setting.BranchId).ToList();
            var customerList = memberList.GroupBy(e => new { e.CustomerId, e.CustomerName }).Select(e => new Customer { Id = e.Key.CustomerId, Name = e.Key.CustomerName }).ToList();
            var deptList = memberList.GroupBy(e => new { e.CustomerId, e.DeptId, e.DeptName }).Select(e => new Dept { Id = e.Key.DeptId, Name = e.Key.DeptName, CustomerId = e.Key.CustomerId }).ToList();

            dbContext.Dispose();
            Logger.Debug("开始执行", DateTime.Now.ToLongTimeString());

            if (setting.Flag == 1)
            {
                // 向Orders表中插入数据
                for (var i = 0; i < OrdersFactoryTaskNum; i++)
                {

                    var task = new Task(() =>
                    {
                        Console.WriteLine("线程ID:{0},开始执行", Thread.CurrentThread.ManagedThreadId);
                        var dbContext1 = new ErpDataBase();
                        DataFactory(dbContext1, setting.OperateMsgList, setting.BranchId, goodsList, userList, salesList, customerList, deptList, memberList);
                    });
                    task.Start();
                }

                Console.ReadKey();
            }
            else if (setting.Flag == 2)
            {
                // 向SaleReportFakeData表插入数据
                for (var i = 0; i < SaleFactoryTaskNum; i++)
                {
                    var task = new Task(() =>
                    {
                        Console.WriteLine(DateTime.Now + "线程ID:{0},开始执行", Thread.CurrentThread.ManagedThreadId);
                        var stw = new Stopwatch();
                        var _dbContext = new ErpDataBase();
                        stw.Start();
                        FactoryToSaleReport(_dbContext, setting);
                        stw.Stop();
                    });
                    task.Start();
                }

                Console.ReadKey();
            }
        }

        /// <summary>
        ///     数据工厂
        /// </summary>
        /// <param name="_dbContext"></param>
        /// <param name="setting"></param>
        private static void FactoryToSaleReport(ErpDataBase _dbContext, setting.setting setting)
        {
            Console.WriteLine("————————" + DateTime.Now + ":开始执行!" + "————————");
            foreach (var iteMsg in setting.OperateMsgList) CreatDateForSaleReport(_dbContext, iteMsg, setting.BranchId);
            Console.WriteLine("————————" + DateTime.Now + ":执行结束!" + "————————");
        }

        /// <summary>
        ///     数据生产线
        /// </summary>
        /// <param name="_dbContext"></param>
        /// <param name="setting"></param>
        /// <param name="brnachId"></param>
        private static void CreatDateForSaleReport(ErpDataBase _dbContext, OperateMsg setting, int brnachId)
        {
            for (var i = 0; i < setting.DataCount / SaleFactoryTaskNum; i++)
            {
                var randomTime = GetRandomTime(setting.StarTime, setting.EndTime);
                var datetime = new DateTime(randomTime.Year, randomTime.Month, randomTime.Day);
                var orderAmount = GetRandomNum(setting.MinSingleOrderAmount, setting.MaxSingleOrderAmount);
                var saleReportFakeData = new SaleReportFakeData
                {
                    BranchId = brnachId,
                    Date = datetime,
                    Count = GetRandomNum(setting.MinSingleOrderCount, setting.MaxSingleOrderCount),
                    OrderAmount = orderAmount,
                    ChargeOff = orderAmount - GetRandomNum(10, 30),
                    GrossProfit = orderAmount - GetRandomNum(15, 20)
                };
                _dbContext.SaleReportFakeData.Add(saleReportFakeData);
                _dbContext.SaveChanges();
            }
        }

        /// <summary>
        ///     数据工厂
        /// </summary>
        private static void DataFactory(ErpDataBase dbContext, List<OperateMsg> opts, int branchId, List<Goods> goodsList, List<int> userList, List<int> salesList,
            IReadOnlyCollection<Customer> customerList, IReadOnlyCollection<Dept> deptList, IReadOnlyCollection<View_Member> memberList)
        {
            foreach (var itemOperate in opts)
                CreateData(dbContext, itemOperate, branchId, goodsList, userList, salesList, customerList, deptList, memberList);

            #region console

            Console.WriteLine("————————" + DateTime.Now + ":执行结束!" + "————————");
            //Console.ReadKey();

            #endregion
        }

        /// <summary>
        ///     生产线
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="setting"></param>
        /// <param name="branchId"></param>
        /// <param name="goodsList"></param>
        /// <param name="userList"></param>
        /// <param name="salesList"></param>
        /// <param name="customerList"></param>
        /// <param name="deptList"></param>
        /// <param name="memberList"></param>
        private static void CreateData(ErpDataBase dbContext, OperateMsg setting, int branchId, List<Goods> goodsList, List<int> userList, List<int> salesList,
            IReadOnlyCollection<Customer> customerList, IReadOnlyCollection<Dept> deptList, IReadOnlyCollection<View_Member> memberList)
        {
            #region console

            Console.WriteLine("CreateData ---start---");
            //Console.WriteLine("\tBranchId:" + branchId + "\n\tOperate:" + JsonConvert.SerializeObject(setting));

            #endregion

            try
            {
                var goodsIds = goodsList.Select(e => e.Id).ToList();
                var customerIds = customerList.Select(e => e.Id).ToList();

                //  生成订单数 setting.DataCount
                for (var i = 0; i < setting.DataCount / OrdersFactoryTaskNum; i++)
                {
                    var customerId = GetSingleOfList(customerIds);
                    var customer = customerList.FirstOrDefault(e => e.Id == customerId);
                    if (customer == null) continue;
                    var deptIds = deptList.Where(e => e.CustomerId == customerId).Select(e => e.Id).ToList();
                    var deptId = GetSingleOfList(deptIds);
                    var dept = deptList.FirstOrDefault(e => e.Id == deptId);
                    if (dept == null) continue;
                    var member = memberList.FirstOrDefault(e => e.CustomerId == customerId && e.DeptId == dept.Id);
                    var dateTime = GetRandomTime(setting.StarTime, setting.EndTime);
                    var saleId = GetSingleOfList(salesList);
                    var currentUserId = GetSingleOfList(userList);

                    //  生成订单
                    var orderId = CreateOrder(dbContext, branchId, customer, dept, member, dateTime, saleId, currentUserId);
                    if (orderId > 0)
                    {
                        var randomGoodIds = GetRandomGoods(goodsIds, setting.MaxDetailCount);
                        goodsList = goodsList.Where(p => randomGoodIds.Contains(p.Id)).ToList();
                        // 生成订单明细
                        CreateOrderDetail(dbContext, orderId, goodsList, setting.MaxGoodsNum);
                        // 计算毛利
                        UpdateOrderSumMoneyAndGrossProfit(dbContext, orderId);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(nameof(CreateData), ex);
            }

            Console.WriteLine("CreateData ---end---" + "\n");
        }

        /// <summary>
        ///     生成订单
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="branchId"></param>
        /// <param name="customer"></param>
        /// <param name="member"></param>
        /// <param name="dateTime"></param>
        /// <param name="saleId"></param>
        /// <param name="currentUserId"></param>
        /// <param name="dept"></param>
        /// <returns>返回创建的订单Id</returns>
        private static int CreateOrder(ErpDataBase dbContext, int branchId, Customer customer, Dept dept, View_Member member, DateTime dateTime, int saleId, int currentUserId)
        {
            try
            {
                Logger.Info("新增订单", $"{branchId}-{customer.Id}");

                var order = new Orders
                {
                    BranchId = branchId,
                    RawOrderId = 0,
                    RawBranchId = branchId,
                    PlanDate = dateTime.AddDays(1), //配送日期
                    Guid = Guid.NewGuid().ToString(),
                    CustomerId = customer.Id,
                    Customer = customer.Name,
                    SalesId = saleId,
                    DeptId = dept.Id,
                    DeptName = dept.Name,
                    MemberId = member.Id,
                    RealName = member.RealName,
                    Telphone = member?.Telphone ?? member.Mobile,
                    Address = member.Province + member.City + member.Area + member.Address,
                    Memo = "20210721add",
                    OrderType = "销售开单",
                    PayType = "在线支付",
                    InvoiceType = "普通发票",
                    ApplyId = 0,
                    LogisticsId = 0,
                    UserId = currentUserId,
                    ServiceId = 1001,
                    ////StoreId = 1001,
                    //StoreName = "张三",
                    PayStatus = "已支付",
                    QuotationStatus = "完成",
                    ServiceStatus = "未处理",
                    PurchaseStatus = "未处理",
                    StoreStatus = "已完成",
                    DeliveryStatus = "已完成",
                    ConfirmStatus = "已确认",
                    UpdateTime = dateTime,
                    OrderTime = dateTime,
                    DeliveryFinishTime = new DateTime(1900, 1, 1),
                    PrintTime = new DateTime(1900, 1, 1),
                    StoreFinishTime = new DateTime(1900, 1, 1),
                    ArchivedTime = new DateTime(1900, 1, 1),
                    FinishDate = new DateTime(1900, 1, 1),
                    ServiceFinishTime = new DateTime(1900, 1, 1),
                    PurchaseFinishTime = new DateTime(1900, 1, 1),
                    ConfirmFinishTime = new DateTime(1900, 1, 1),
                    GroupReceivePercent = 0,
                    RowNum = 0,
                    SumMoney = 0,
                    GrossProfit = 0,
                    Point = 0,
                    IsInvoice = 0,
                    SaveNum = 0,
                    PrintNum = 0,
                    PackageNum = 0,
                    ChargeOff = 0,
                    GrossProfitPercent = 0,
                    AuditStatus = 0,
                    AuditReason = 0,
                    Balance = 0,
                    PayAmount = 0,
                    Freight = 0,
                    OrderAmount = 0,
                    TaxMoney = 0,
                    NoTaxMoney = 0,
                    IsEmergency = false,
                    IsShowAmountInPrint = false,
                    IsEnable = true,
                    IsInner = false,
                    IsDelete = false,
                    IsStorage = false,
                    IsCopied = false,
                    IsArchive = false,
                    IsChecked = false,
                    GroupChecked = false,
                    IsConfirm = true,
                    Checkout = false
                };

                dbContext.Orders.Add(order);
                dbContext.SaveChanges();

                return order.Id > 0 ? order.Id : 0;
            }
            catch (Exception ex)
            {
                Logger.Error("新增订单失败", ex);
                return 0;
            }
        }

        /// <summary>
        ///     生成订单明细
        /// </summary>
        /// <param name="dbContext"></param>
        /// <param name="orderId"></param>
        /// <param name="goodsList"></param>
        /// <param name="maxGoodsNum"></param>
        /// <returns></returns>
        private static bool CreateOrderDetail(ErpDataBase dbContext, int orderId, IEnumerable<Goods> goodsList, int maxGoodsNum)
        {
            var orderDetails = new List<OrderDetail>();
            const int maxAmount = 6600;
            var amountNum = (decimal) 0;
            foreach (var goods in goodsList)
            {
                var num = GetRandomNum(1, maxGoodsNum);
                var amount = CalculateOrderAmount(goods.Price, num);
                var noTaxAmount = CalcNoTaxAmountRoundFour(amount, (decimal)0.13);
                var taxRate = (decimal)0.130;
                var taxAmount = CalcTaxAmountRoundFour(amount, noTaxAmount);

                amount = amount == 0 ? maxAmount : amount;
                amount = amount >= (maxAmount - amountNum) ? (maxAmount - amountNum + 1) : amount;
                if (amountNum > maxAmount)
                {
                    break;
                }
                else
                {
                    orderDetails.Add(new OrderDetail
                    {
                        OrderId = orderId,
                        GoodsId = goods.Id,
                        Num = num,
                        Price = goods.Price,
                        AC = goods.InPrice,
                        Amount = amount,
                        Point = 0,
                        PickNum = 0,
                        IsGift = false,
                        IsTotalPriceModel = false,
                        IsCustomGoods = false,
                        AntiCounterfeiting = false,
                        DisplayNum = num,
                        DisplayUnit = goods.Unit != "" ? goods.Unit : "个",
                        DisplayPrice = goods.Price,
                        IsComment = false,
                        OldOrderId = 0,
                        RefundNum = 0,
                        GrossProfit = UpdateGrossProfit(amount, taxAmount, goods.InPrice, num),
                        TaxRate = taxRate,
                        TaxAmount = taxAmount,
                        NoTaxAmount = noTaxAmount,
                        NoTaxPrice = CalcNoTaxAmountRoundFour(goods.Price, taxRate),
                        DisplayNoTaxPrice = CalcNoTaxAmountRoundFour(goods.Price, taxRate),
                        AFC = goods.InPrice,
                        Discount = 1,
                        DisplayAmount = amount,
                        GrossProfitPercent = UpdateGrossProfitPercent(amount, taxAmount, goods.InPrice, num)
                    });
                }
                amountNum += amount;
            }

            dbContext.OrderDetail.AddRange(orderDetails);
            dbContext.SaveChanges();

            return true;
        }


        /// <summary>
        ///     更新单品毛利率
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        private static decimal UpdateGrossProfit(decimal amount, decimal taxAmount, decimal ac, int num)
        {
            return MathRoundFour(amount - taxAmount - ac * num);
        }

        private static int GetRandomNum(int min, int max)
        {
            var random = new Random(Guid.NewGuid().GetHashCode());
            var num = random.Next(min, max);
            return num;
        }

        /// <summary>
        ///     计算税额
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="noTaxAmount"></param>
        /// <returns></returns>
        private static decimal CalcTaxAmountRoundFour(decimal amount, decimal noTaxAmount)
        {
            return MathRoundFour(amount - noTaxAmount);
        }

        /// <summary>
        ///     更新单品毛利率
        /// </summary>
        /// <param name="detail"></param>
        /// <returns></returns>
        private static string UpdateGrossProfitPercent(decimal amount, decimal taxAmount, decimal ac, int num)
        {
            var percent = "0";
            if (amount != 0)
            {
                var p = Math.Round((amount - taxAmount - ac * num) / (amount - taxAmount), 6, MidpointRounding.AwayFromZero);
                p = Math.Round(p, 4, MidpointRounding.AwayFromZero);
                percent = Math.Round(p * 100, 2, MidpointRounding.AwayFromZero) + "%";
            }

            return percent;
        }

        /// <summary>
        ///     计算金额（四舍五入保留四位小数） jiaqiu
        /// </summary>
        /// <returns></returns>
        private static decimal CalculateOrderAmount(decimal price, int num)
        {
            var amount = price * num;
            amount = Math.Round(amount, 4, MidpointRounding.AwayFromZero);
            return amount;
        }

        /// <summary>
        ///     计算不含税额
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="taxRate"></param>
        /// <returns></returns>
        private static decimal CalcNoTaxAmountRoundFour(decimal amount, decimal taxRate)
        {
            return MathRoundFour(amount / (1 + taxRate));
        }

        /// <summary>
        ///     金额保留4位数
        /// </summary>
        /// <param name="money">金额</param>
        /// <returns></returns>
        private static decimal MathRoundFour(decimal money)
        {
            return Math.Round(money, 4, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        ///     随机生成订单明细中的商品
        /// </summary>
        /// <param name="list"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        private static List<int> GetRandomGoods(List<int> list, int max)
        {
            var ints = new List<int>();
            var num = GetRandomNum(1, max);
            for (var i = 0; i < num; i++) ints.Add(GetSingleOfList(list));

            return ints;
        }

        /// <summary>
        ///     随机抽取int类型List
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private static int GetSingleOfList(List<int> list)
        {
            if (list == null) throw new ArgumentNullException(nameof(list));
            var index = GetRandomNum(0, list.Count);

            return list[index];
        }

        /// <summary>
        ///     在区间时间段内随机生成时间点
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        private static DateTime GetRandomTime(DateTime start, DateTime end)
        {
            var faker = new Faker<Date>()
                .RuleFor(o => o.date, f => f.Date.Between(start, end));
            return faker.Generate(1)[0].date;
        }

        /// <summary>
        ///     更新订单的总价、毛利和行数，凡是修改订单的地方都要调用： 下单、改单、拆单（包括：现场退单）、拣货完成（出库完毕）
        /// </summary>
        /// <param name="orderId"></param>
        private static int UpdateOrderSumMoneyAndGrossProfit(ErpDataBase _dbContext, int orderId)
        {
            var sql =
                $@"update Orders set SumMoney=ISNULL((select SUM(Amount) from OrderDetail where OrderDetail.OrderId={orderId} ),0),
                                        ChargeOff = ISNULL( ( SELECT SUM ( Amount ) FROM OrderDetail WHERE OrderDetail.OrderId={orderId} ), 0 ),
                                        TaxMoney=ISNULL((select SUM(TaxAmount) from OrderDetail where OrderDetail.OrderId={orderId} ),0),
                                        NoTaxMoney=ISNULL((select SUM(NoTaxAmount) from OrderDetail where OrderDetail.OrderId={orderId} ),0),
                                        OrderAmount=ISNULL((select SUM(Amount) from OrderDetail where OrderDetail.OrderId={orderId} ),0) + Freight,
                                        GrossProfit =  cast(round(ISNUll((select SUM(od.Amount-od.TaxAmount-(od.AC*od.Num)-((od.Amount-od.TaxAmount-od.TaxAmount) * o.GroupReceivePercent/100))                      
                                        from OrderDetail od inner join  Orders o on o.Id = od.OrderId where od.OrderId={orderId}),0),4) as numeric(20,4)),
                                        RowNum =(select COUNT(*) from OrderDetail where OrderDetail.OrderId={orderId}  ),
                                        UpdateTime = Getdate() 
                                        where Id={orderId}";
            sql +=
                $@" update Orders set GrossProfitPercent=GrossProfit/(case when NoTaxMoney=0 then 1 else NoTaxMoney end )  where id={orderId}  ";

            return _dbContext.Database.ExecuteSqlCommand(sql);
        }
    }
}