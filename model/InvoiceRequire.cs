namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceRequire")]
    public partial class InvoiceRequire
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int MemberId { get; set; }

        public int StatementId { get; set; }

        [Required]
        [StringLength(500)]
        public string InvoiceName { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceType { get; set; }

        [Required]
        public string InvoiceContent { get; set; }

        [Column(TypeName = "money")]
        public decimal InvoiceAmount { get; set; }

        [StringLength(1000)]
        public string InvoiceMemo { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceStatus { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }

        [StringLength(20)]
        public string DistributionType { get; set; }

        public bool IsRelateDetail { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(20)]
        public string BuyerTaxNum { get; set; }

        [StringLength(200)]
        public string BuyerBank { get; set; }

        [StringLength(100)]
        public string BuyerBankAccount { get; set; }

        [StringLength(80)]
        public string BuyerAddress { get; set; }

        [StringLength(200)]
        public string SaleName { get; set; }

        [StringLength(20)]
        public string SaleTaxNum { get; set; }

        [StringLength(200)]
        public string SaleBank { get; set; }

        [StringLength(100)]
        public string SaleBankAccount { get; set; }

        [StringLength(20)]
        public string SalePhone { get; set; }

        [StringLength(200)]
        public string SaleAddress { get; set; }

        public bool IsCrossInvoice { get; set; }

        public int PreInvoiceId { get; set; }

        [StringLength(50)]
        public string BuyerPhone { get; set; }
    }
}
