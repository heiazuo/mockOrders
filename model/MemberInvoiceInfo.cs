namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberInvoiceInfo")]
    public partial class MemberInvoiceInfo
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        [Required]
        [StringLength(100)]
        public string MemberName { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceCategory { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceType { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceContent { get; set; }

        [Required]
        [StringLength(200)]
        public string InvoiceName { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceTaxNo { get; set; }

        [Required]
        [StringLength(500)]
        public string InvoiceAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoicePhone { get; set; }

        [Required]
        [StringLength(100)]
        public string InvoiceBank { get; set; }

        [Required]
        [StringLength(100)]
        public string InvoiceBankAccount { get; set; }

        [StringLength(500)]
        public string InvoiceMemo { get; set; }

        [StringLength(200)]
        public string EmailForInvoice { get; set; }

        public int? CustomerId { get; set; }

        public bool? IsDefault { get; set; }

        [StringLength(50)]
        public string InvoiceReceivePhone { get; set; }
    }
}
