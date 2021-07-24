namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOStatement")]
    public partial class DOStatement
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [Column(TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Column(TypeName = "money")]
        public decimal PaidMoney { get; set; }

        [Required]
        [StringLength(50)]
        public string PayStatus { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        public int PrintNum { get; set; }

        [StringLength(50)]
        public string InvoiceType { get; set; }

        [StringLength(50)]
        public string InvoiceStatus { get; set; }

        [Column(TypeName = "money")]
        public decimal InvoiceMoney { get; set; }

        public int UserId { get; set; }

        [Column(TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Column(TypeName = "money")]
        public decimal InvoiceChargeOff { get; set; }

        [Column(TypeName = "money")]
        public decimal SumGoodsAmount { get; set; }

        public DateTime? UpdateTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? ApplyReceiveMoney { get; set; }

        [Column(TypeName = "money")]
        public decimal? ApplyInvoiceMoney { get; set; }
    }
}
