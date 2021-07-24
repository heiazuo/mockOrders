namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseQuoteDetail")]
    public partial class PurchaseQuoteDetail
    {
        public int Id { get; set; }

        public int PurchaseQuoteId { get; set; }

        public int GoodsId { get; set; }

        public int DonvvSKU { get; set; }

        public int Num { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [Required]
        [StringLength(50)]
        public string Unit { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
