namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventory")]
    public partial class Inventory
    {
        public int Id { get; set; }

        public int StoreId { get; set; }

        [Required]
        [StringLength(100)]
        public string StoreZone { get; set; }

        public int GoodsId { get; set; }

        public int Num { get; set; }

        public decimal AC { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool IsCustomGoods { get; set; }

        public int OrderDetailId { get; set; }

        [StringLength(200)]
        public string StoreZoneMemo { get; set; }

        public int GiftNum { get; set; }

        public decimal AFC { get; set; }
    }
}
