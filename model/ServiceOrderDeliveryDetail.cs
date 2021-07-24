namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceOrderDeliveryDetail")]
    public partial class ServiceOrderDeliveryDetail
    {
        public int Id { get; set; }

        public int DeliveryId { get; set; }

        public int OrderId { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
