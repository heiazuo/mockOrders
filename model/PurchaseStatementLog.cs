namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseStatementLog")]
    public partial class PurchaseStatementLog
    {
        public int Id { get; set; }

        public int PurchaseStatementId { get; set; }

        [StringLength(50)]
        public string OperateType { get; set; }

        public DateTime? OperateTime { get; set; }

        public int? OperateUserId { get; set; }

        [StringLength(100)]
        public string OperateUserName { get; set; }

        public string Remark { get; set; }
    }
}
