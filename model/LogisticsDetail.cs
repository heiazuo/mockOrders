namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogisticsDetail")]
    public partial class LogisticsDetail
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }

        public DateTime OperateTime { get; set; }

        [Required]
        [StringLength(100)]
        public string Operator { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
