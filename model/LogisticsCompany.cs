namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogisticsCompany")]
    public partial class LogisticsCompany
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(100)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool IsDisable { get; set; }

        public int SupportedId { get; set; }
    }
}
