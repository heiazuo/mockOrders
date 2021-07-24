namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchERPSetting
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(100)]
        public string ERPName { get; set; }

        [StringLength(500)]
        public string IconUrl { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
