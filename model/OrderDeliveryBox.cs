namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDeliveryBox")]
    public partial class OrderDeliveryBox
    {
        public int Id { get; set; }

        public int OrderDeliveryId { get; set; }

        public int OrderBoxId { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [Required]
        [StringLength(200)]
        public string Latitude { get; set; }

        [Required]
        [StringLength(200)]
        public string Longitude { get; set; }
    }
}
