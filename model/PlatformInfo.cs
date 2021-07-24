namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlatformInfo")]
    public partial class PlatformInfo
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int I_ProjectId { get; set; }

        [Required]
        [StringLength(100)]
        public string PlatformCode { get; set; }

        [Required]
        [StringLength(100)]
        public string PlatformName { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
