namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchThemeArea
    {
        public int Id { get; set; }

        public int ThemeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public int Cols { get; set; }

        public int Rows { get; set; }

        public int Row_Height { get; set; }

        public int Col_Width { get; set; }

        [Required]
        [StringLength(1000)]
        public string Remark { get; set; }

        public int Sort { get; set; }

        public bool IsEnable { get; set; }

        public DateTime UpdateTime { get; set; }

        public int Col_Space { get; set; }

        public int Row_Space { get; set; }
    }
}
