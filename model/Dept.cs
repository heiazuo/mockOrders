namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dept")]
    public partial class Dept
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Code { get; set; }

        [StringLength(100)]
        public string PCode { get; set; }

        public int Level { get; set; }

        public bool IsSepareSettle { get; set; }

        public bool IsSepareOrder { get; set; }

        public DateTime UpdateTime { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        public bool IsBalance { get; set; }
    }
}
