namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchAds
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int TypeId { get; set; }

        [StringLength(500)]
        public string Image1 { get; set; }

        [Required]
        [StringLength(500)]
        public string Href1 { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
