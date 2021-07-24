namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchTopMenu
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(500)]
        public string Url { get; set; }

        public bool IsBlank { get; set; }

        public int Sort { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
