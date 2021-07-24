namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogisticsSubscribeLog")]
    public partial class LogisticsSubscribeLog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string TrackingNumber { get; set; }

        [Required]
        public string Context { get; set; }

        public DateTime AddTime { get; set; }
    }
}
