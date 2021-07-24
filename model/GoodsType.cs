namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsType")]
    public partial class GoodsType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        public string PCode { get; set; }

        public int Level { get; set; }

        public int PointRate { get; set; }

        [Required]
        [StringLength(200)]
        public string PriceArea { get; set; }

        public bool IsVisible { get; set; }

        public bool IsLeaf { get; set; }

        [StringLength(50)]
        public string DefaultUnit { get; set; }

        [StringLength(50)]
        public string DefaultSource { get; set; }

        public DateTime UpdateTime { get; set; }

        [StringLength(50)]
        public string PY { get; set; }

        public int BranchId { get; set; }
    }
}
