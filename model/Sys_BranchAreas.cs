namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchAreas
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Sort { get; set; }

        public int Header_Height { get; set; }

        [Required]
        [StringLength(50)]
        public string Header_BackGroundColor { get; set; }

        public int Header_FontSize { get; set; }

        [Required]
        [StringLength(50)]
        public string Header_FontColor { get; set; }

        public int Cols { get; set; }

        public int Rows { get; set; }

        [Required]
        [StringLength(500)]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool IsShowHeader { get; set; }

        public int Row_Height { get; set; }

        public int Col_Width { get; set; }

        public int Col_Space { get; set; }

        public int Row_Space { get; set; }

        public int Border_width { get; set; }

        [Required]
        [StringLength(10)]
        public string Border_color { get; set; }

        public bool IsEnable { get; set; }
    }
}
