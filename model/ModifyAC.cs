namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ModifyAC")]
    public partial class ModifyAC
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int GoodsId { get; set; }

        [Required]
        [StringLength(50)]
        public string Unit { get; set; }

        public decimal OldInPrice { get; set; }

        public decimal OldAC { get; set; }

        public bool ModifyGoodsInPrice { get; set; }

        public decimal NewInPrice { get; set; }

        public bool ModifyInventoryAC { get; set; }

        public int StockNum { get; set; }

        public int ModifyOrderDetailAC { get; set; }

        public int OrderCount { get; set; }

        public decimal NewAC { get; set; }

        public int UserId { get; set; }

        [StringLength(1000)]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
