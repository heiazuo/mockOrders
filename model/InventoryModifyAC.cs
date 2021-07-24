namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryModifyAC")]
    public partial class InventoryModifyAC
    {
        public int Id { get; set; }

        public int ModifyACId { get; set; }

        public int StoreId { get; set; }

        [Required]
        [StringLength(100)]
        public string StoreZone { get; set; }

        public int GoodsId { get; set; }

        public int Num { get; set; }

        public decimal OldAC { get; set; }

        public decimal NewAC { get; set; }

        [StringLength(200)]
        public string StoreZoneMemo { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
