namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_OrderPicking
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PickingUserId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DistributeUserId { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime UpdateTime { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptId { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string OrderType { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime OrderTime { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime PlanDate { get; set; }

        public DateTime? FinishDate { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RowNum { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal OrderAmount { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "money")]
        public decimal GrossProfit { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "money")]
        public decimal Point { get; set; }

        [StringLength(500)]
        public string Customer { get; set; }

        [StringLength(100)]
        public string DeptName { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrintNum { get; set; }

        [Key]
        [Column(Order = 17)]
        public DateTime PrintTime { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool IsEnable { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool IsEmergency { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool IsInner { get; set; }

        [Key]
        [Column(Order = 21)]
        public bool IsDelete { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool IsCopied { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RawOrderId { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string StoreStatus { get; set; }

        [StringLength(50)]
        public string ServiceStatus { get; set; }

        [StringLength(50)]
        public string PurchaseStatus { get; set; }

        [StringLength(50)]
        public string DeliveryStatus { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PackageNum { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        [Column(TypeName = "text")]
        public string Memo { get; set; }

        [StringLength(50)]
        public string Guid { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [Key]
        [Column(Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 27)]
        public bool IsShowAmountInPrint { get; set; }

        [Key]
        [Column(Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesId { get; set; }

        [Key]
        [Column(Order = 29)]
        [StringLength(50)]
        public string SalesName { get; set; }

        public int? StoreId { get; set; }

        [StringLength(50)]
        public string StoreName { get; set; }

        [StringLength(200)]
        public string ThirdPartyId { get; set; }
    }
}
