namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceOrderStaff")]
    public partial class ServiceOrderStaff
    {
        public int Id { get; set; }

        public int ServiceId { get; set; }

        public int UserId { get; set; }
    }
}
