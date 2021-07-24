namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VIPCounterLabel")]
    public partial class VIPCounterLabel
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(500)]
        public string Label { get; set; }

        public DateTime? CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
