namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_InvoiceRequireDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatementId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(500)]
        public string InvoiceName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string InvoiceType { get; set; }

        [Key]
        [Column(Order = 5)]
        public string InvoiceContent { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal InvoiceAmount { get; set; }

        [StringLength(1000)]
        public string InvoiceMemo { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string InvoiceStatus { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime UpdateTime { get; set; }

        [StringLength(20)]
        public string DistributionType { get; set; }

        [Key]
        [Column(Order = 10)]
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

        [StringLength(80)]
        public string SaleAddress { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool IsCrossInvoice { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxRate { get; set; }

        public decimal? InvoiceMoney { get; set; }

        public int? OrderId { get; set; }

        public int? DetailStatementId { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsInvoiceNum { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderDetailId { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceRequireId { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(500)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        [StringLength(500)]
        public string GoodsName { get; set; }

        [StringLength(500)]
        public string TaxCode { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ODNum { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ODPickNum { get; set; }
    }
}
