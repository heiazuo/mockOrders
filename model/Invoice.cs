namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Invoice")]
    public partial class Invoice
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int CustomerId { get; set; }

        public int OrderStatementId { get; set; }

        public int InvoiceRequireId { get; set; }

        public DateTime InvoiceDate { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceNo { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceType { get; set; }

        [Column(TypeName = "money")]
        public decimal InvoiceMoney { get; set; }

        [Required]
        [StringLength(500)]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(20)]
        public string InvoiceCode { get; set; }

        [Required]
        public string Content { get; set; }

        public int? ReceiveMoneyId { get; set; }

        public bool? IsPushInvoicePlat { get; set; }

        [StringLength(100)]
        public string OrderNo { get; set; }

        [StringLength(100)]
        public string PlatInvoiceRequestNo { get; set; }

        public bool? IsInvoiceSuccess { get; set; }

        [StringLength(500)]
        public string PdfUrl { get; set; }

        [StringLength(500)]
        public string InvoiceDetailUrl { get; set; }

        public bool IsRelateDetail { get; set; }

        [StringLength(200)]
        public string PlatIdentity { get; set; }
    }
}
