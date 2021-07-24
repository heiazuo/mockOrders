namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_PrintTemplate
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Content { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
