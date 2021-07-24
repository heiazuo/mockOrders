namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Purchase
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
        public int StoreId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NeedToPurchaseId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierId { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string PurchaseType { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime PurchaseDate { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string PayStatus { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceiptUserId { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string SupplierStatus { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }

        [StringLength(200)]
        public string SupplierName { get; set; }

        [StringLength(100)]
        public string ShortName { get; set; }

        [StringLength(50)]
        public string PayType { get; set; }

        public int? ExpiredPayment { get; set; }

        [StringLength(50)]
        public string SupplierTaxNo { get; set; }

        [StringLength(500)]
        public string OpeningBank { get; set; }

        [StringLength(50)]
        public string BankAccount { get; set; }

        [StringLength(50)]
        public string LinkMan { get; set; }

        [StringLength(100)]
        public string TelPhone { get; set; }

        [StringLength(100)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool IsChecked { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 14)]
        public DateTime AddTime { get; set; }

        [StringLength(50)]
        public string ReceiptName { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 16)]
        public DateTime PutInStoreTime { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool IsDelete { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool IsMerge { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool IsBrandPurchase { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AddUserId { get; set; }

        [StringLength(50)]
        public string AddUserName { get; set; }

        public int? OrderId { get; set; }

        [StringLength(50)]
        public string StoreName { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "money")]
        public decimal TaxMoney { get; set; }

        [Key]
        [Column(Order = 22, TypeName = "money")]
        public decimal NoTaxMoney { get; set; }

        public DateTime? EstimateRecieveDate { get; set; }

        [StringLength(64)]
        public string ThirdPartyId { get; set; }
    }
}
