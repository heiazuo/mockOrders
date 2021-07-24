namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsPackage")]
    public partial class GoodsPackage
    {
        public int Id { get; set; }

        public int GoodsId { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public int Num { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int IsDefault { get; set; }

        [Required]
        [StringLength(100)]
        public string BarCode { get; set; }

        public DateTime UpdateTime { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public decimal? PriceExtend { get; set; }

        [StringLength(100)]
        public string DonvvSpuCode { get; set; }

        [StringLength(100)]
        public string DonvvSkuCode { get; set; }
    }
}
