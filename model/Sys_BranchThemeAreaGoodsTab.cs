namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchThemeAreaGoodsTab
    {
        public int Id { get; set; }

        public int ThemeAreaId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [Required]
        [StringLength(100)]
        public string SearchType { get; set; }

        public bool IsShowHead { get; set; }

        public int Sort { get; set; }

        [Required]
        [StringLength(200)]
        public string TabHref { get; set; }

        public bool IsEnable { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
