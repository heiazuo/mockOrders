namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderAfterSalePhoto")]
    public partial class OrderAfterSalePhoto
    {
        public int Id { get; set; }

        public int AfterSaleId { get; set; }

        public int OrderId { get; set; }

        [Required]
        [StringLength(500)]
        public string PhotoUrl { get; set; }

        public DateTime AddTime { get; set; }
    }
}
