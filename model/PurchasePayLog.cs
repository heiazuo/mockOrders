namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchasePayLog")]
    public partial class PurchasePayLog
    {
        public int Id { get; set; }

        public int PayId { get; set; }

        public decimal? PayMoney { get; set; }

        public decimal? ChargeOff { get; set; }

        [StringLength(50)]
        public string OperateType { get; set; }

        public DateTime? OperateTime { get; set; }

        public int? OperateUserId { get; set; }

        [StringLength(100)]
        public string OperateUserName { get; set; }

        public string Remark { get; set; }
    }
}
