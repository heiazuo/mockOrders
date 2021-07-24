namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerLog")]
    public partial class CustomerLog
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int CustomerId { get; set; }

        [Required]
        [StringLength(200)]
        public string Customer { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Category { get; set; }

        [Required]
        [StringLength(200)]
        public string Operate { get; set; }

        public DateTime AddTime { get; set; }

        public string Tracking { get; set; }
    }
}
