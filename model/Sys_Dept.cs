namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Dept
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Code { get; set; }

        [Required]
        [StringLength(20)]
        public string PCode { get; set; }

        [StringLength(100)]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
