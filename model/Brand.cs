namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Brand")]
    public partial class Brand
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string EnglishName { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(500)]
        public string Company { get; set; }

        [StringLength(50)]
        public string ProductPlace { get; set; }

        [StringLength(500)]
        public string WebSite { get; set; }

        [StringLength(500)]
        public string LogoUrl { get; set; }

        public int BranchId { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }

        [StringLength(100)]
        public string PY { get; set; }
    }
}
