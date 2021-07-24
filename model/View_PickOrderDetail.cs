namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_PickOrderDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal AC { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal Amount { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal Point { get; set; }

        [StringLength(200)]
        public string PurchaseMemo { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PickNum { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool IsGift { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(500)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string Unit { get; set; }

        [StringLength(100)]
        public string StoreZone { get; set; }

        public int? StoreId { get; set; }

        public int? StoreNum { get; set; }

        public int? InventoryId { get; set; }

        public bool? IsDefault { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string StoreZoneMemo { get; set; }

        public int? BranchId { get; set; }
    }
}
