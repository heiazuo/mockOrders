namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SiChuanLog")]
    public partial class SiChuanLog
    {
        public int Id { get; set; }

        public int? OrderId { get; set; }

        [StringLength(2000)]
        public string Content { get; set; }

        public int? UserId { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
