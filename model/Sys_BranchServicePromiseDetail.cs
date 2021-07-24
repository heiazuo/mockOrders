namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchServicePromiseDetail
    {
        public int Id { get; set; }

        public int PromiseId { get; set; }

        public int Sort { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        [Required]
        [StringLength(500)]
        public string Href { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(500)]
        public string ImgUrl { get; set; }
    }
}
