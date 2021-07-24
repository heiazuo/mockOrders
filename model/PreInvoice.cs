namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PreInvoice")]
    public partial class PreInvoice
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [Required]
        [StringLength(200)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(500)]
        public string InvoiceName { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceType { get; set; }

        [Required]
        public string InvoiceContent { get; set; }

        [Required]
        [StringLength(20)]
        public string InvoiceCode { get; set; }

        public DateTime InvoiceDate { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceNo { get; set; }

        [StringLength(1000)]
        public string InvoiceRemark { get; set; }

        [StringLength(100)]
        public string InvoiceEmail { get; set; }

        [StringLength(50)]
        public string InvoiceMobile { get; set; }

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

        [StringLength(80)]
        public string SaleAddress { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }

        [StringLength(20)]
        public string DistributionType { get; set; }

        public int MemberId { get; set; }

        [Column(TypeName = "money")]
        public decimal InitialAmount { get; set; }

        [Required]
        [StringLength(10)]
        public string Operate { get; set; }

        [Column(TypeName = "money")]
        public decimal PreInvoiceAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal InvoiceAmount { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        public int BranchId { get; set; }
    }
}
