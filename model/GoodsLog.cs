namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsLog")]
    public partial class GoodsLog
    {
        public int Id { get; set; }

        public int GoodsId { get; set; }

        public int Category { get; set; }

        public DateTime CreationTime { get; set; }

        public int CreatorUserId { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        public int Tenant { get; set; }

        [Required]
        [StringLength(200)]
        public string GoodsName { get; set; }

        [Required]
        [StringLength(200)]
        public string UserName { get; set; }

        public string Tracking { get; set; }
    }
}
