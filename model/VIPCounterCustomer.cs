namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VIPCounterCustomer")]
    public partial class VIPCounterCustomer
    {
        public int Id { get; set; }

        public int CounterId { get; set; }

        public int CustomerId { get; set; }

        public DateTime UpdateTime { get; set; }

        public decimal Discount { get; set; }

        public int UserId { get; set; }
    }
}
