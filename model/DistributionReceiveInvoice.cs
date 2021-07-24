namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DistributionReceiveInvoice")]
    public partial class DistributionReceiveInvoice
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int ChildBranchId { get; set; }

        public int InvoiceType { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceNo { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceCode { get; set; }

        public DateTime InvoiceDate { get; set; }

        public DateTime ReceiveDate { get; set; }

        [Column(TypeName = "money")]
        public decimal InvoiceMoney { get; set; }

        [Column(TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Required]
        [StringLength(200)]
        public string BuyerName { get; set; }

        [Required]
        [StringLength(20)]
        public string BuyerTaxNo { get; set; }

        [StringLength(200)]
        public string BuyerBank { get; set; }

        [StringLength(100)]
        public string BuyerBankAccount { get; set; }

        [StringLength(20)]
        public string BuyerPhone { get; set; }

        [StringLength(80)]
        public string BuyerAddress { get; set; }

        [StringLength(200)]
        public string SaleName { get; set; }

        [StringLength(20)]
        public string SaleTaxNo { get; set; }

        [StringLength(200)]
        public string SaleBank { get; set; }

        [StringLength(100)]
        public string SaleBankAccount { get; set; }

        [StringLength(20)]
        public string SalePhone { get; set; }

        [StringLength(80)]
        public string SaleAddress { get; set; }

        [StringLength(1000)]
        public string Memo { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool IsDelete { get; set; }

        public int StatementId { get; set; }
    }
}
