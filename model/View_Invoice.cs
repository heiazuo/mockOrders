namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Invoice
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
        public int CustomerId { get; set; }

        [StringLength(50)]
        public string CustomerType { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoiceRequireId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string InvoiceCode { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string InvoiceNo { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(500)]
        public string InvoiceName { get; set; }

        [Key]
        [Column(Order = 7)]
        public string InvoiceContent { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string InvoiceStatus { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderStatementId { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(200)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal InvoiceMoney { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string InvoiceType { get; set; }

        [Key]
        [Column(Order = 15)]
        public string Content { get; set; }

        [Key]
        [Column(Order = 16)]
        public DateTime InvoiceDate { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(500)]
        public string Memo { get; set; }

        [StringLength(20)]
        public string DistributionType { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "money")]
        public decimal PaidMoney { get; set; }

        [Key]
        [Column(Order = 20, TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "money")]
        public decimal AllInvoiceMoney { get; set; }

        [StringLength(50)]
        public string StatementUser { get; set; }

        [StringLength(50)]
        public string InvoiceUser { get; set; }

        [StringLength(50)]
        public string InvoiceRequireUser { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesId { get; set; }

        [StringLength(50)]
        public string SalesName { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServiceId { get; set; }

        [StringLength(50)]
        public string ServiceName { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Credit { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreditDays { get; set; }

        [Key]
        [Column(Order = 26)]
        public bool IsRelateDetail { get; set; }

        public int? ReceiveMoneyId { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(500)]
        public string PdfUrl { get; set; }

        [StringLength(500)]
        public string InvoiceDetailUrl { get; set; }

        [StringLength(50)]
        public string PayStatus { get; set; }

        [StringLength(100)]
        public string PlatInvoiceRequestNo { get; set; }

        public bool? IsInvoiceSuccess { get; set; }

        public bool? IsPushInvoicePlat { get; set; }

        public string StatementIds { get; set; }

        [Key]
        [Column(Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PreInvoiceId { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalesCost { get; set; }

        [StringLength(50)]
        public string BuyerPhone { get; set; }
    }
}
