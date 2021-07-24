namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchHelp
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public DateTime UpdateTime { get; set; }

        public int GroupId { get; set; }

        public int BranchId { get; set; }

        public bool IsLocked { get; set; }
    }
}
