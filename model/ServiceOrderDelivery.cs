namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceOrderDelivery")]
    public partial class ServiceOrderDelivery
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public int CarUserId { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
