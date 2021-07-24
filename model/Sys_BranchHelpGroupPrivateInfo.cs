namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchHelpGroupPrivateInfo
    {
        public int Id { get; set; }

        public int GroupId { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(50)]
        public string Alias { get; set; }

        public int Sort { get; set; }

        public bool IsDisable { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
