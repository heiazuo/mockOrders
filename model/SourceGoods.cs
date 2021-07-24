namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SourceGoods
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int SourceId { get; set; }

        [Required]
        [StringLength(500)]
        public string Url { get; set; }

        [Required]
        [StringLength(200)]
        public string SourceSku { get; set; }

        [StringLength(200)]
        public string SourceMainSku { get; set; }

        [StringLength(200)]
        public string SpecVals { get; set; }

        [Required]
        [StringLength(200)]
        public string SourceCategory { get; set; }

        [Required]
        [StringLength(200)]
        public string SourceBrand { get; set; }

        [Column(TypeName = "money")]
        public decimal SourcePrice { get; set; }

        public int TargetParentId { get; set; }

        public int TargetGoodsId { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        public int DataSource { get; set; }
    }
}
