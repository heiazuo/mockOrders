namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchFloorBrandingWallPhotos
    {
        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string ImgPath { get; set; }

        [Required]
        [StringLength(300)]
        public string ImgHref { get; set; }

        public int BranchFloorId { get; set; }

        public DateTime UpdateTime { get; set; }

        public DateTime AddTime { get; set; }

        public int Sort { get; set; }

        public bool IsDelete { get; set; }
    }
}
