namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_UrlLog
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string IP { get; set; }

        [StringLength(500)]
        public string Url { get; set; }

        [StringLength(1000)]
        public string Memo { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
