namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsPhoto")]
    public partial class GoodsPhoto
    {
        public int Id { get; set; }

        public int GoodsId { get; set; }

        [Required]
        [StringLength(500)]
        public string PhotoUrl { get; set; }

        public bool IsHomeImage { get; set; }

        public bool IsDetailPhoto { get; set; }

        public int Sort { get; set; }

        public int? UserId { get; set; }

        public DateTime UpdateTime { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        [Required]
        [StringLength(500)]
        public string Photo250Url { get; set; }

        [Required]
        [StringLength(500)]
        public string Photo100Url { get; set; }

        public int ImgServerId { get; set; }
    }
}
