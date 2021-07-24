namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchTheme
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public bool IsEnable { get; set; }

        [StringLength(100)]
        public string BgColor { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
