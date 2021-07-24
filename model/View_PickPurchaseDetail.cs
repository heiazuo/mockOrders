namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_PickPurchaseDetail
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
        public decimal InPrice { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal Amount { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceivedNum { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool IsEmergency { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierNum { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "date")]
        public DateTime DelayDate { get; set; }

        [StringLength(50)]
        public string PurchaseStatus { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(1000)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string Unit { get; set; }

        public int? InventoryId { get; set; }

        public int? StoreId { get; set; }

        [StringLength(100)]
        public string StoreZone { get; set; }

        public int? StoreNum { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public bool? IsDefault { get; set; }

        [StringLength(200)]
        public string StoreZoneMemo { get; set; }

        public int? BranchId { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool IsCustomGoods { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderDetailId { get; set; }

        [StringLength(500)]
        public string DetailMemo { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool I_IsCustomGoods { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int I_OrderDetailId { get; set; }

        public bool? IsAddDeviceCode { get; set; }
    }
}
