namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Orders
    {
        [StringLength(100)]
        public string LoginName { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Guid { get; set; }

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
        public int DeptId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string OrderType { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime OrderTime { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime PlanDate { get; set; }

        public DateTime? FinishDate { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RowNum { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal Freight { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "money")]
        public decimal OrderAmount { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal GrossProfit { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "money")]
        public decimal Point { get; set; }

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

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsInvoice { get; set; }

        [StringLength(200)]
        public string InvoiceName { get; set; }

        [StringLength(50)]
        public string InvoiceType { get; set; }

        [StringLength(4000)]
        public string InvoiceContent { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SaveNum { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrintNum { get; set; }

        [Key]
        [Column(Order = 18)]
        public DateTime PrintTime { get; set; }

        [StringLength(50)]
        public string PayType { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(50)]
        public string PayStatus { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool IsEnable { get; set; }

        [Key]
        [Column(Order = 21)]
        public bool IsEmergency { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool IsInner { get; set; }

        [Key]
        [Column(Order = 23)]
        public bool IsDelete { get; set; }

        [Key]
        [Column(Order = 24)]
        public bool IsStorage { get; set; }

        [Key]
        [Column(Order = 25)]
        public bool IsCopied { get; set; }

        [Key]
        [Column(Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RawOrderId { get; set; }

        [Key]
        [Column(Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesId { get; set; }

        [Key]
        [Column(Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServiceId { get; set; }

        [StringLength(50)]
        public string ServiceStatus { get; set; }

        public DateTime? ServiceFinishTime { get; set; }

        [StringLength(50)]
        public string PurchaseStatus { get; set; }

        public DateTime? PurchaseFinishTime { get; set; }

        [StringLength(50)]
        public string StoreStatus { get; set; }

        [Key]
        [Column(Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PackageNum { get; set; }

        [StringLength(50)]
        public string DeliveryStatus { get; set; }

        public DateTime? DeliveryFinishTime { get; set; }

        [Key]
        [Column(Order = 31)]
        public bool IsArchive { get; set; }

        [Key]
        [Column(Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApplyId { get; set; }

        [StringLength(200)]
        public string I_Name { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string SalesName { get; set; }

        [StringLength(50)]
        public string ServiceName { get; set; }

        [Key]
        [Column(Order = 33)]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 34)]
        public bool IsChecked { get; set; }

        [StringLength(100)]
        public string I_OrderId { get; set; }

        [Key]
        [Column(Order = 35)]
        public DateTime StoreFinishTime { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public DateTime? AddTime { get; set; }

        public int? SalesId_Now { get; set; }

        [StringLength(50)]
        public string SalesName_Now { get; set; }

        [Key]
        [Column(Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RawBranchId { get; set; }

        [Key]
        [Column(Order = 37)]
        [StringLength(100)]
        public string ShortName { get; set; }

        [Key]
        [Column(Order = 38)]
        public bool GroupChecked { get; set; }

        public int? SalesDeptId { get; set; }

        [StringLength(50)]
        public string SalesDeptName { get; set; }

        [Key]
        [Column(Order = 39)]
        public bool IsConfirm { get; set; }

        [StringLength(50)]
        public string ConfirmStatus { get; set; }

        public DateTime? ConfirmFinishTime { get; set; }

        [Key]
        [Column(Order = 40)]
        public bool IsShowAmountInPrint { get; set; }

        [Key]
        [Column(Order = 41)]
        public double GroupReceivePercent { get; set; }

        [StringLength(200)]
        public string ThirdPartyId { get; set; }

        [Key]
        [Column(Order = 42)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AuditStatus { get; set; }

        [Key]
        [Column(Order = 43)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AuditReason { get; set; }

        [StringLength(300)]
        public string AuditRemark { get; set; }

        public string InvoiceInfo { get; set; }

        public int? StoreId { get; set; }

        [StringLength(50)]
        public string StoreName { get; set; }

        [Key]
        [Column(Order = 44)]
        public bool Checkout { get; set; }

        [Key]
        [Column(Order = 45)]
        public DateTime ArchivedTime { get; set; }

        public bool? IsSpecial { get; set; }

        public bool? CreateVoucherResult { get; set; }

        public int? FinancialSoftware { get; set; }

        [StringLength(100)]
        public string CustomerShortName { get; set; }

        [Key]
        [Column(Order = 46, TypeName = "money")]
        public decimal TaxMoney { get; set; }

        [Key]
        [Column(Order = 47, TypeName = "money")]
        public decimal NoTaxMoney { get; set; }

        [Key]
        [Column(Order = 48, TypeName = "money")]
        public decimal GrossProfitPercent { get; set; }

        [StringLength(50)]
        public string ArchiveUser { get; set; }

        [StringLength(50)]
        public string CustomerType { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumAC { get; set; }

        [StringLength(50)]
        public string OrderSource { get; set; }

        [Column(TypeName = "money")]
        public decimal? DisPlayAmount { get; set; }
    }
}
