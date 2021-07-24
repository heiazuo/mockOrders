namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_EfficientGoods
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int IProjectId { get; set; }

        public int GoodsId { get; set; }

        [Required]
        [StringLength(500)]
        public string GoodsName { get; set; }

        [Required]
        [StringLength(200)]
        public string Model { get; set; }

        [Required]
        [StringLength(100)]
        public string EfficientGoodsCardNum { get; set; }

        [StringLength(200)]
        public string EfficientGoodsImagePath { get; set; }

        [StringLength(100)]
        public string EfficientGoodsCardOrgan { get; set; }

        public DateTime AddAt { get; set; }

        [StringLength(50)]
        public string AddBy { get; set; }

        public DateTime UpdateAt { get; set; }

        public DateTime? EfficientGoodsIndate { get; set; }
    }
}
