namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogisticsInfomation")]
    public partial class LogisticsInfomation
    {
        public int Id { get; set; }

        public int LogisticsCompanyId { get; set; }

        [Required]
        [StringLength(100)]
        public string TrackingNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string FromUser { get; set; }

        [Required]
        [StringLength(50)]
        public string FromTelphone { get; set; }

        [Required]
        [StringLength(200)]
        public string FromAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string ToUser { get; set; }

        [Required]
        [StringLength(50)]
        public string ToTelphone { get; set; }

        [Required]
        [StringLength(200)]
        public string ToAddress { get; set; }

        [Required]
        [StringLength(300)]
        public string ImgUrl { get; set; }

        public DateTime UpdateTime { get; set; }

        public int OrderId { get; set; }

        [Required]
        public string LogisticsInfo { get; set; }

        public int? OrderType { get; set; }
    }
}
