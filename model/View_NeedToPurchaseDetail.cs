namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_NeedToPurchaseDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NeedToPurchaseId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LackNum { get; set; }

        [StringLength(100)]
        public string PurchaseType { get; set; }

        [StringLength(200)]
        public string PurchaseMemo { get; set; }

        [StringLength(100)]
        public string CreditCard { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Emergency { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierId { get; set; }

        public int? UserId { get; set; }

        public decimal? InPrice { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime UpdateTime { get; set; }

        [StringLength(200)]
        public string SupplierName { get; set; }

        [StringLength(100)]
        public string ShortName { get; set; }

        [StringLength(50)]
        public string TypeName { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(500)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string Unit { get; set; }

        [StringLength(50)]
        public string PurchaseUserName { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool IsCustomGoods { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderDetailId { get; set; }

        public string Memo { get; set; }

        [Key]
        [Column(Order = 12)]
        public string GoodsMemo { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; set; }

        [StringLength(50)]
        public string StoreName { get; set; }
    }
}
