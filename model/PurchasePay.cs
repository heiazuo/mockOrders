namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchasePay")]
    public partial class PurchasePay
    {
        public int Id { get; set; }

        public int PurchaseStatementId { get; set; }

        [Column(TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Column(TypeName = "money")]
        public decimal PayMoney { get; set; }

        [Required]
        [StringLength(50)]
        public string PayType { get; set; }

        public DateTime PayDate { get; set; }

        [StringLength(200)]
        public string Memo { get; set; }

        public int UserId { get; set; }

        public int? ApplyUserId { get; set; }

        public DateTime UpdateTime { get; set; }

        [StringLength(50)]
        public string PayAccount { get; set; }

        public int PrepaymentId { get; set; }
    }
}
