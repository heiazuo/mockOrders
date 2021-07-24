namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_InvoiceRequire
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
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatementId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(500)]
        public string InvoiceName { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string InvoiceType { get; set; }

        [Key]
        [Column(Order = 6)]
        public string InvoiceContent { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal InvoiceAmount { get; set; }

        [StringLength(1000)]
        public string InvoiceMemo { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string InvoiceStatus { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime UpdateTime { get; set; }

        [StringLength(20)]
        public string DistributionType { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(100)]
        public string ShortName { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Credit { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreditDays { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "money")]
        public decimal InvoiceMoney { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "money")]
        public decimal NeedToInvoice { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(50)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 20, TypeName = "money")]
        public decimal SumGoodsAmount { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatementManId { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesId { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(50)]
        public string StatementName { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(50)]
        public string SalesName { get; set; }

        [Key]
        [Column(Order = 25)]
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

        public string StatementIds { get; set; }

        [Key]
        [Column(Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PreInvoiceId { get; set; }

        [StringLength(50)]
        public string BuyerPhone { get; set; }
    }
}
