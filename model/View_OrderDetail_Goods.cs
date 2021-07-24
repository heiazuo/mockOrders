namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_OrderDetail_Goods
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

        public string SingleRemark { get; set; }

        public string InternalRemark { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool IsTotalPriceModel { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool IsCustomGoods { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool AntiCounterfeiting { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DisplayNum { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string DisplayUnit { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "money")]
        public decimal DisplayPrice { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool IsComment { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OldOrderId { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RefundNum { get; set; }

        [StringLength(50)]
        public string GrossProfitPercent { get; set; }

        [StringLength(1000)]
        public string DisplayName { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        public decimal? InPrice { get; set; }

        public int? TypeId { get; set; }

        public int? BrandId { get; set; }

        public int? MinimumQuantity { get; set; }

        [StringLength(200)]
        public string SN { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "money")]
        public decimal GrossProfit { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal Discount { get; set; }
    }
}
