namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PageView")]
    public partial class PageView
    {
        public int Id { get; set; }

        public int BId { get; set; }

        [StringLength(100)]
        public string BName { get; set; }

        public int UId { get; set; }

        [Required]
        [StringLength(50)]
        public string Unique { get; set; }

        [Required]
        [StringLength(50)]
        public string PageUnique { get; set; }

        [StringLength(255)]
        public string Url { get; set; }

        [Required]
        [StringLength(255)]
        public string Host { get; set; }

        [StringLength(255)]
        public string Origin { get; set; }

        [Required]
        [StringLength(500)]
        public string Refer { get; set; }

        [Required]
        [StringLength(255)]
        public string ContentType { get; set; }

        [StringLength(50)]
        public string Browser { get; set; }

        [Required]
        [StringLength(20)]
        public string DeviceType { get; set; }

        [Required]
        [StringLength(500)]
        public string UserAgent { get; set; }

        [StringLength(255)]
        public string UrlMd5 { get; set; }

        [StringLength(1024)]
        public string Body { get; set; }

        [StringLength(255)]
        public string Scene { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }

        [StringLength(50)]
        public string Ip { get; set; }

        [StringLength(255)]
        public string Lon { get; set; }

        [StringLength(255)]
        public string Lat { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(255)]
        public string Before { get; set; }

        [StringLength(50)]
        public string Platform { get; set; }

        public long TimeSpan { get; set; }

        public long StartTimeSpan { get; set; }

        public long EndTimeSpan { get; set; }
    }
}
