namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_QuotationOrder
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime QuotationTime { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime ValidTime { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ValidDay { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool QuotationIsDelete { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [StringLength(50)]
        public string Guid { get; set; }

        public int? DeptId { get; set; }

        public int? MemberId { get; set; }

        [StringLength(50)]
        public string OrderType { get; set; }

        public DateTime? OrderTime { get; set; }

        public DateTime? PlanDate { get; set; }

        public DateTime? UpdateTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumMoney { get; set; }

        [Column(TypeName = "money")]
        public decimal? GrossProfit { get; set; }

        [Column(TypeName = "money")]
        public decimal? Point { get; set; }

        [StringLength(500)]
        public string Customer { get; set; }

        [StringLength(100)]
        public string DeptName { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [Column(TypeName = "text")]
        public string Memo { get; set; }

        [StringLength(50)]
        public string InvoiceType { get; set; }

        public int? SaveNum { get; set; }

        [StringLength(50)]
        public string PayStatus { get; set; }

        [StringLength(50)]
        public string PayType { get; set; }

        public bool? IsEnable { get; set; }

        public bool? IsEmergency { get; set; }

        public bool? IsInner { get; set; }

        public bool? OrderIsDelete { get; set; }

        public bool? IsStorage { get; set; }

        public bool? IsCopied { get; set; }

        public int? RawOrderId { get; set; }

        public int? UserId { get; set; }

        public int? SalesId { get; set; }

        public int? ServiceId { get; set; }

        [StringLength(50)]
        public string ServiceStatus { get; set; }

        public DateTime? ServiceFinishTime { get; set; }

        [StringLength(50)]
        public string PurchaseStatus { get; set; }

        public DateTime? PurchaseFinishTime { get; set; }

        [StringLength(50)]
        public string StoreStatus { get; set; }

        public int? PackageNum { get; set; }

        [StringLength(50)]
        public string DeliveryStatus { get; set; }

        public bool? IsArchive { get; set; }

        public int? ApplyId { get; set; }

        [StringLength(100)]
        public string I_OrderId { get; set; }

        [StringLength(200)]
        public string I_Name { get; set; }

        public decimal? ChargeOff { get; set; }

        public bool? IsChecked { get; set; }

        [StringLength(50)]
        public string DeliveryType { get; set; }

        public int? RawBranchId { get; set; }

        public bool? GroupChecked { get; set; }

        [StringLength(50)]
        public string InvoiceCategory { get; set; }

        [StringLength(200)]
        public string EmailForInvoice { get; set; }

        public string InvoiceInfo { get; set; }

        public bool? IsConfirm { get; set; }

        [StringLength(50)]
        public string ConfirmStatus { get; set; }

        public DateTime? ConfirmFinishTime { get; set; }

        public bool? IsShowAmountInPrint { get; set; }

        [StringLength(50)]
        public string QuotationStatus { get; set; }

        [StringLength(20)]
        public string PaymentType { get; set; }

        public int? LogisticsId { get; set; }

        public double? GroupReceivePercent { get; set; }

        public int? RowNum { get; set; }

        [StringLength(50)]
        public string SalesName { get; set; }
    }
}
