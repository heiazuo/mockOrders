namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_Category
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int I_PlatId { get; set; }

        [Required]
        [StringLength(100)]
        public string I_TypeCode { get; set; }

        [Required]
        [StringLength(100)]
        public string I_TypeName { get; set; }

        [Column("I_Category")]
        [Required]
        [StringLength(100)]
        public string I_Category1 { get; set; }

        public int TypeId { get; set; }

        public DateTime? UpdateTime { get; set; }

        public decimal Discount { get; set; }

        public decimal? Discount2 { get; set; }

        public decimal? Discount3 { get; set; }

        public decimal? Discount4 { get; set; }
    }
}
