namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_DOStatement
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal PaidMoney { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string PayStatus { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrintNum { get; set; }

        [StringLength(50)]
        public string InvoiceType { get; set; }

        [StringLength(50)]
        public string InvoiceStatus { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal InvoiceMoney { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "money")]
        public decimal InvoiceChargeOff { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal SumGoodsAmount { get; set; }

        public DateTime? UpdateTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? ApplyReceiveMoney { get; set; }

        [Column(TypeName = "money")]
        public decimal? ApplyInvoiceMoney { get; set; }

        [StringLength(200)]
        public string Customer { get; set; }

        [StringLength(50)]
        public string Operator { get; set; }
    }
}
