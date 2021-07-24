namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchThemeAreaPhoto
    {
        public int Id { get; set; }

        public int ThemeAreaId { get; set; }

        public int Sort { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        [Required]
        [StringLength(200)]
        public string ImgHref { get; set; }

        [Required]
        [StringLength(200)]
        public string ImgUrl { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool IsEnable { get; set; }
    }
}
