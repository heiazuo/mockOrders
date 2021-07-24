namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_DistributionReceiveInvoice
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChildBranchId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceType { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string InvoiceNo { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string InvoiceCode { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime InvoiceDate { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime ReceiveDate { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal InvoiceMoney { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(200)]
        public string BuyerName { get; set; }

        [Key]
        [Column(Order = 11)]
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

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 13)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(100)]
        public string ChildBranchName { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool IsDelete { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatementId { get; set; }
    }
}
