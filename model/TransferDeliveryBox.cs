namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransferDeliveryBox")]
    public partial class TransferDeliveryBox
    {
        public int Id { get; set; }

        public int TransferDeliveryId { get; set; }

        public int TransferBoxId { get; set; }

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
