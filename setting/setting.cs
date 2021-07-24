using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpDataFactory.setting
{
    class setting
    {
        public int Flag{ get; set; }
        public int BranchId { get; set; }
        public List<OperateMsg> OperateMsgList { get; set; }
    }

    public class OperateMsg
    {
        /// <summary>
        ///     开始时间
        /// </summary>
        public DateTime StarTime { get; set; }
        /// <summary>
        ///     结束时间
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        ///     生产数据条数
        /// </summary>
        public int DataCount { get; set; }

        public int MaxDetailCount { get; set; }


        public int  MaxGoodsNum { get; set; }

        public int MaxSingleOrderAmount { get; set; }
        public int MinSingleOrderAmount { get; set; }
        public int MaxSingleOrderCount { get; set; }
        public int MinSingleOrderCount { get; set; }
    }
}
