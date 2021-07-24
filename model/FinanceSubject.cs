namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FinanceSubject")]
    public partial class FinanceSubject
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(100)]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Pcode { get; set; }

        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public DateTime? AddAt { get; set; }

        public DateTime? UpdatetAt { get; set; }
    }
}
