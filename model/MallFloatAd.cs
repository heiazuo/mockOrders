namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MallFloatAd")]
    public partial class MallFloatAd
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int UserId { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        [StringLength(50)]
        public string Position { get; set; }

        [StringLength(200)]
        public string ImgPath { get; set; }

        [StringLength(200)]
        public string ImgUrl { get; set; }

        public int? Height { get; set; }

        public int? Width { get; set; }

        [StringLength(2000)]
        public string Code { get; set; }

        public bool IsEnable { get; set; }
    }
}
