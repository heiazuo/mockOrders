namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderLog")]
    public partial class OrderLog
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [Required]
        [StringLength(200)]
        public string Operate { get; set; }

        public bool IsInner { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
