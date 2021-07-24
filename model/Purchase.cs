namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Purchase")]
    public partial class Purchase
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int StoreId { get; set; }

        public int NeedToPurchaseId { get; set; }

        public int SupplierId { get; set; }

        public DateTime PurchaseDate { get; set; }

        [Required]
        [StringLength(50)]
        public string PurchaseType { get; set; }

        [Column(TypeName = "money")]
        public decimal SumMoney { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [Required]
        [StringLength(50)]
        public string SupplierStatus { get; set; }

        public bool IsChecked { get; set; }

        [Required]
        [StringLength(50)]
        public string PayStatus { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        public int ReceiptUserId { get; set; }

        public int UserId { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime UpdateTime { get; set; }

        [Column(TypeName = "money")]
        public decimal ChargeOff { get; set; }

        public DateTime PutInStoreTime { get; set; }

        public int SaveNum { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }

        public bool IsDelete { get; set; }

        public bool IsMerge { get; set; }

        public bool IsBrandPurchase { get; set; }

        public int AddUserId { get; set; }

        public int? OrderId { get; set; }

        [Column(TypeName = "money")]
        public decimal TaxMoney { get; set; }

        [Column(TypeName = "money")]
        public decimal NoTaxMoney { get; set; }

        public DateTime? EstimateRecieveDate { get; set; }

        [StringLength(64)]
        public string ThirdPartyId { get; set; }
    }
}
