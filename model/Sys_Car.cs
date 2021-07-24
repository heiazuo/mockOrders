namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Car
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(50)]
        public string Plate { get; set; }

        public bool IsEnable { get; set; }

        [StringLength(200)]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
