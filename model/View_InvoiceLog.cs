namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_InvoiceLog
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

        [StringLength(500)]
        public string InvoiceName { get; set; }

        public string InvoiceContent { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime InvoiceCreateTime { get; set; }

        [StringLength(50)]
        public string InvoiceStatus { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderStatementId { get; set; }

        public int? MemberId { get; set; }

        [StringLength(200)]
        public string CustomerName { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal InvoiceMoney { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string InvoiceType { get; set; }

        [Key]
        [Column(Order = 10)]
        public string Content { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime InvoiceDate { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(500)]
        public string Memo { get; set; }

        [StringLength(20)]
        public string DistributionType { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "money")]
        public decimal PaidMoney { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "money")]
        public decimal AllInvoiceMoney { get; set; }

        [StringLength(50)]
        public string StatementUser { get; set; }

        [StringLength(50)]
        public string InvoiceCreateUser { get; set; }

        [StringLength(50)]
        public string InvoiceDeleteUser { get; set; }

        [StringLength(50)]
        public string InvoiceRequireUser { get; set; }

        public int? SalesId { get; set; }

        [StringLength(50)]
        public string SalesName { get; set; }

        public int? ServiceId { get; set; }

        [StringLength(50)]
        public string ServiceName { get; set; }

        public int? Credit { get; set; }

        public int? CreditDays { get; set; }

        public bool? IsRelateDetail { get; set; }

        public int? ReceiveMoneyId { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [Key]
        [Column(Order = 17)]
        public DateTime InvoiceDeleteTime { get; set; }

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

        [StringLength(1000)]
        public string CancelPdfUrl { get; set; }

        [StringLength(1000)]
        public string CancelDetailUrl { get; set; }

        [StringLength(200)]
        public string CancelOrderNo { get; set; }

        [StringLength(200)]
        public string CancelPlatInvoiceRequestNo { get; set; }

        [StringLength(500)]
        public string StatementIds { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumAC { get; set; }
    }
}
