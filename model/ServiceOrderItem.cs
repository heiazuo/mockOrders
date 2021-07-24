namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceOrderItem")]
    public partial class ServiceOrderItem
    {
        public int Id { get; set; }

        public int ServiceId { get; set; }

        public int? Item { get; set; }

        [Required]
        [StringLength(200)]
        public string ItemName { get; set; }

        public int Num { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }
    }
}
