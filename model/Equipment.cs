namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Equipment")]
    public partial class Equipment
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string DeviceNum { get; set; }

        public int GoodsId { get; set; }

        [Required]
        [StringLength(500)]
        public string GoodsName { get; set; }

        public DateTime? GuaranteeDate { get; set; }

        public DateTime? Production { get; set; }

        public DateTime? AddAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        public int Status { get; set; }
    }
}
