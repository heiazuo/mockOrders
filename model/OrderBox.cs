namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderBox")]
    public partial class OrderBox
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int BoxId { get; set; }

        public int PrintNum { get; set; }

        public DateTime PrintTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(50)]
        public string StoreZone { get; set; }

        public DateTime UpdateTime { get; set; }

        public int PackageNumber { get; set; }
    }
}
