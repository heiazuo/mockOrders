namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DistributionPay")]
    public partial class DistributionPay
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int ChildBranchId { get; set; }

        [Column(TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Column(TypeName = "money")]
        public decimal PayMoney { get; set; }

        public DateTime PayDate { get; set; }

        [Required]
        [StringLength(50)]
        public string PayType { get; set; }

        public int? PayAccount { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool IsDelete { get; set; }

        public int StatementId { get; set; }
    }
}
