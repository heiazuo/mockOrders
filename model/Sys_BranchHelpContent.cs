namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchHelpContent
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int HelpId { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Content { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
