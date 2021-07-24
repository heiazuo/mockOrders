namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Member_Orders
    {
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
        [Column(Order = 11, TypeName = "money")]
        public decimal OrderAmount { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "money")]
        public decimal GrossProfit { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
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
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsInvoice { get; set; }

        [StringLength(200)]
        public string InvoiceName { get; set; }

        [StringLength(50)]
        public string InvoiceType { get; set; }

        [StringLength(4000)]
        public string InvoiceContent { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SaveNum { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrintNum { get; set; }

        [Key]
        [Column(Order = 17)]
        public DateTime PrintTime { get; set; }

        [StringLength(50)]
        public string PayType { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(50)]
        public string PayStatus { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool IsEnable { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool IsEmergency { get; set; }

        [Key]
        [Column(Order = 21)]
        public bool IsInner { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool IsDelete { get; set; }

        [Key]
        [Column(Order = 23)]
        public bool IsStorage { get; set; }

        [Key]
        [Column(Order = 24)]
        public bool IsCopied { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RawOrderId { get; set; }

        [Key]
        [Column(Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesId { get; set; }

        [Key]
        [Column(Order = 28)]
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
        [Column(Order = 29)]
        public DateTime StoreFinishTime { get; set; }

        [Key]
        [Column(Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PackageNum { get; set; }

        [StringLength(50)]
        public string DeliveryStatus { get; set; }

        public DateTime? DeliveryFinishTime { get; set; }

        [StringLength(50)]
        public string DeliveryType { get; set; }

        [Key]
        [Column(Order = 31)]
        public bool IsArchive { get; set; }

        [Key]
        [Column(Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApplyId { get; set; }

        [StringLength(100)]
        public string I_OrderId { get; set; }

        [StringLength(200)]
        public string I_Name { get; set; }

        [Key]
        [Column(Order = 33)]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 34)]
        public bool IsChecked { get; set; }

        [Key]
        [Column(Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RawBranchId { get; set; }

        [Key]
        [Column(Order = 36)]
        public bool GroupChecked { get; set; }

        [StringLength(50)]
        public string MemberName { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Code { get; set; }

        [StringLength(100)]
        public string PCode { get; set; }

        [StringLength(20)]
        public string PaymentType { get; set; }
    }
}
