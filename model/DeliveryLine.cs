namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeliveryLine")]
    public partial class DeliveryLine
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(50)]
        public string LineName { get; set; }

        [StringLength(200)]
        public string LineRange { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
