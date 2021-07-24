namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_Goods
    {
        public int Id { get; set; }

        public int I_ProjectId { get; set; }

        public int GoodsId { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Unit { get; set; }

        public int Num { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool IsEnable { get; set; }

        public decimal Discount { get; set; }

        [Column(TypeName = "money")]
        public decimal? MarketPrice { get; set; }

        public bool? IsModify { get; set; }

        public int? StockNum { get; set; }

        public bool? IsNeededPush { get; set; }
    }
}
