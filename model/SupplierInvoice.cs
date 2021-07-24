namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplierInvoice")]
    public partial class SupplierInvoice
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int SupplierId { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceType { get; set; }

        [Required]
        [StringLength(500)]
        public string InvoiceName { get; set; }

        [Required]
        [StringLength(20)]
        public string InvoiceCode { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceNo { get; set; }

        [Column(TypeName = "money")]
        public decimal InvoiceMoney { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime InvoiceDate { get; set; }

        [Required]
        [StringLength(500)]
        public string Memo { get; set; }

        public DateTime ReceiveDate { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool IsDelete { get; set; }

        [StringLength(50)]
        public string InvoiceCompany { get; set; }
    }
}
