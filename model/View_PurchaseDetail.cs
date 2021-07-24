namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_PurchaseDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PurchaseId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal BillsPrice { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal InPrice { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal Amount { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceivedNum { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool IsEmergency { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierNum { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "date")]
        public DateTime DelayDate { get; set; }

        [StringLength(50)]
        public string PurchaseStatus { get; set; }

        [StringLength(500)]
        public string DisplayName { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        public decimal? Price { get; set; }

        public bool? IsEnable { get; set; }

        public bool? IsWeb { get; set; }

        public int? SaleNumber { get; set; }

        public int? SaleCount { get; set; }

        public int? StockNum { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierId { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NeedToPurchaseId { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string SupplierStatus { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool IsChecked { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string PayStatus { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceiptUserId { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 20)]
        public DateTime PurchaseDate { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(50)]
        public string PurchaseType { get; set; }

        [Key]
        [Column(Order = 22)]
        public DateTime AddTime { get; set; }

        [Key]
        [Column(Order = 23)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; set; }

        [StringLength(200)]
        public string SupplierName { get; set; }

        [StringLength(100)]
        public string SupplierShortName { get; set; }

        [StringLength(50)]
        public string LinkMan { get; set; }

        [StringLength(100)]
        public string TelPhone { get; set; }

        [StringLength(100)]
        public string Mobile { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        [StringLength(500)]
        public string DetailMemo { get; set; }

        [StringLength(50)]
        public string PurchaseName { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 26)]
        public DateTime PutInStoreTime { get; set; }

        [Key]
        [Column(Order = 27)]
        public bool IsCustomGoods { get; set; }

        [Key]
        [Column(Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderDetailId { get; set; }

        [Key]
        [Column(Order = 29)]
        public bool IsDelete { get; set; }

        [Key]
        [Column(Order = 30)]
        public bool IsMerge { get; set; }

        [Key]
        [Column(Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OldPurchaseId { get; set; }

        public bool? IsDonvvSupply { get; set; }

        [StringLength(100)]
        public string DonvvBrandName { get; set; }

        public int? DonvvSKU { get; set; }

        [StringLength(200)]
        public string SN { get; set; }

        [StringLength(50)]
        public string DonvvBrandId { get; set; }

        [Key]
        [Column(Order = 32)]
        public bool IsGift { get; set; }

        [Key]
        [Column(Order = 33)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AddUserId { get; set; }

        [StringLength(50)]
        public string AddUserName { get; set; }

        [Key]
        [Column(Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RefundNum { get; set; }

        public int? OrderId { get; set; }

        [StringLength(20)]
        public string InvoiceType { get; set; }

        [Key]
        [Column(Order = 35, TypeName = "money")]
        public decimal TaxRate { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 36, TypeName = "money")]
        public decimal TaxMoney { get; set; }

        [Key]
        [Column(Order = 37, TypeName = "money")]
        public decimal NoTaxMoney { get; set; }

        [Key]
        [Column(Order = 38, TypeName = "money")]
        public decimal TaxAmount { get; set; }

        [Key]
        [Column(Order = 39, TypeName = "money")]
        public decimal NoTaxAmount { get; set; }

        [Key]
        [Column(Order = 40, TypeName = "money")]
        public decimal NoTaxInPrice { get; set; }

        [Key]
        [Column(Order = 41)]
        public bool IsTotalAmount { get; set; }
    }
}
