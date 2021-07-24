namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderCheckoutLog")]
    public partial class OrderCheckoutLog
    {
        public int Id { get; set; }

        public int Count { get; set; }

        public DateTime CheckoutTime { get; set; }

        public DateTime CreationTime { get; set; }

        public int CreatorUserId { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        public int Tenant { get; set; }
    }
}
