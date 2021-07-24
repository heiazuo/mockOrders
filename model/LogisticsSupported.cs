namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogisticsSupported")]
    public partial class LogisticsSupported
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string LogisticsCompany { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string Code { get; set; }

        [StringLength(1000)]
        public string Memo { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string CountryCode { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime UpdateTime { get; set; }
    }
}
