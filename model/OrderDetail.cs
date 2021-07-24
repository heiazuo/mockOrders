namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int GoodsId { get; set; }

        public int Num { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "money")]
        public decimal AC { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [Column(TypeName = "money")]
        public decimal Point { get; set; }

        [StringLength(200)]
        public string PurchaseMemo { get; set; }

        public int PickNum { get; set; }

        public bool IsGift { get; set; }

        public string SingleRemark { get; set; }

        public string InternalRemark { get; set; }

        public bool IsTotalPriceModel { get; set; }

        public bool IsCustomGoods { get; set; }

        public bool AntiCounterfeiting { get; set; }

        public int DisplayNum { get; set; }

        [Required]
        [StringLength(50)]
        public string DisplayUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal DisplayPrice { get; set; }

        public bool IsComment { get; set; }

        public int OldOrderId { get; set; }

        public int RefundNum { get; set; }

        [StringLength(50)]
        public string GrossProfitPercent { get; set; }

        [Column(TypeName = "money")]
        public decimal TaxRate { get; set; }

        [Column(TypeName = "money")]
        public decimal TaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal NoTaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal GrossProfit { get; set; }

        [Column(TypeName = "money")]
        public decimal NoTaxPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal DisplayNoTaxPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal AFC { get; set; }

        public decimal Discount { get; set; }

        [Column(TypeName = "money")]
        public decimal DisplayAmount { get; set; }
    }
}
