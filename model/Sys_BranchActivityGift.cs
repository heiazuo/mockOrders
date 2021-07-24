namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchActivityGift
    {
        public int Id { get; set; }

        public int ActivityId { get; set; }

        public int ActivityRuleId { get; set; }

        public int GiftNum { get; set; }

        public int MaxGiftNum { get; set; }

        public int GoodsId { get; set; }

        [Required]
        [StringLength(500)]
        public string GoodsName { get; set; }

        [Required]
        [StringLength(50)]
        public string Unit { get; set; }

        [Column(TypeName = "money")]
        public decimal SalePrice { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
