namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_OrderDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal AC { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal Amount { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal Point { get; set; }

        [StringLength(200)]
        public string PurchaseMemo { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PickNum { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool IsGift { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeId { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrandId { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(1000)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(500)]
        public string HomeImage { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal GoodsPrice { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MinimumQuantity { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptId { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { get; set; }

        [Key]
        [Column(Order = 21)]
        public DateTime OrderTime { get; set; }

        [Key]
        [Column(Order = 22)]
        public DateTime PlanDate { get; set; }

        [Key]
        [Column(Order = 23)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 24)]
        public bool IsEnable { get; set; }

        [Key]
        [Column(Order = 25)]
        public bool IsEmergency { get; set; }

        [Key]
        [Column(Order = 26)]
        public bool IsInner { get; set; }

        [Key]
        [Column(Order = 27)]
        public bool IsDelete { get; set; }

        [Key]
        [Column(Order = 28)]
        public bool IsStorage { get; set; }

        [Key]
        [Column(Order = 29)]
        public bool IsCopied { get; set; }

        [Key]
        [Column(Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RawOrderId { get; set; }

        [StringLength(50)]
        public string ServiceStatus { get; set; }

        [StringLength(50)]
        public string PurchaseStatus { get; set; }

        [StringLength(50)]
        public string StoreStatus { get; set; }

        [StringLength(50)]
        public string DeliveryStatus { get; set; }

        [StringLength(100)]
        public string DeptName { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        public int? StoreId { get; set; }

        [StringLength(50)]
        public string StoreName { get; set; }

        [Key]
        [Column(Order = 31)]
        [StringLength(50)]
        public string Model { get; set; }

        [Key]
        [Column(Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SaleNumber { get; set; }

        [Key]
        [Column(Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SaleCount { get; set; }

        [Key]
        [Column(Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StockNum { get; set; }

        [Key]
        [Column(Order = 35)]
        [StringLength(200)]
        public string SN { get; set; }

        [StringLength(500)]
        public string Customer { get; set; }

        [StringLength(100)]
        public string CustomerShortName { get; set; }

        [Key]
        [Column(Order = 36, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 37, TypeName = "money")]
        public decimal OrderAmount { get; set; }

        public string SingleRemark { get; set; }

        public string InternalRemark { get; set; }

        [StringLength(100)]
        public string I_OrderId { get; set; }

        [Key]
        [Column(Order = 38)]
        [StringLength(50)]
        public string OrderType { get; set; }

        [Key]
        [Column(Order = 39)]
        public DateTime StoreFinishTime { get; set; }

        [Key]
        [Column(Order = 40)]
        public bool IsTotalPriceModel { get; set; }

        [Key]
        [Column(Order = 41)]
        public bool IsConfirm { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [Column(TypeName = "text")]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesId { get; set; }

        [Key]
        [Column(Order = 43)]
        [StringLength(50)]
        public string SalesName { get; set; }

        [Key]
        [Column(Order = 44)]
        public bool IsCustomGoods { get; set; }

        [Key]
        [Column(Order = 45)]
        public bool AntiCounterfeiting { get; set; }

        [Key]
        [Column(Order = 46)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DisplayNum { get; set; }

        [Key]
        [Column(Order = 47)]
        [StringLength(50)]
        public string DisplayUnit { get; set; }

        [Key]
        [Column(Order = 48)]
        public bool IsComment { get; set; }

        [Key]
        [Column(Order = 49, TypeName = "money")]
        public decimal DisplayPrice { get; set; }

        public DateTime? DeliveryFinishTime { get; set; }

        [Key]
        [Column(Order = 50)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OldOrderId { get; set; }

        [Key]
        [Column(Order = 51)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RefundNum { get; set; }

        [StringLength(50)]
        public string GrossProfitPercent { get; set; }

        [Key]
        [Column(Order = 52, TypeName = "money")]
        public decimal AFC { get; set; }

        public DateTime? PurchaseFinishTime { get; set; }

        [Key]
        [Column(Order = 53, TypeName = "money")]
        public decimal GrossProfit { get; set; }

        [Key]
        [Column(Order = 54)]
        public bool Checkout { get; set; }

        [Key]
        [Column(Order = 55, TypeName = "money")]
        public decimal TaxMoney { get; set; }

        [Key]
        [Column(Order = 56, TypeName = "money")]
        public decimal NoTaxMoney { get; set; }

        [Key]
        [Column(Order = 57, TypeName = "money")]
        public decimal OrderGrossProfitPercent { get; set; }

        [Key]
        [Column(Order = 58, TypeName = "money")]
        public decimal TaxRate { get; set; }

        [Key]
        [Column(Order = 59, TypeName = "money")]
        public decimal TaxAmount { get; set; }

        [Key]
        [Column(Order = 60, TypeName = "money")]
        public decimal NoTaxAmount { get; set; }

        [Key]
        [Column(Order = 61, TypeName = "money")]
        public decimal DetailGrossProfit { get; set; }

        [Key]
        [Column(Order = 62, TypeName = "money")]
        public decimal NoTaxPrice { get; set; }

        [Key]
        [Column(Order = 63, TypeName = "money")]
        public decimal DisplayNoTaxPrice { get; set; }

        [StringLength(50)]
        public string Tpn { get; set; }

        [StringLength(100)]
        public string LoginName { get; set; }

        [Key]
        [Column(Order = 64, TypeName = "money")]
        public decimal DisplayAmount { get; set; }

        [Key]
        [Column(Order = 65)]
        public decimal Discount { get; set; }

        public bool? IsAddDeviceCode { get; set; }

        [StringLength(500)]
        public string TPName { get; set; }
    }
}
