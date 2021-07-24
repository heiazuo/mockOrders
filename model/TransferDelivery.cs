namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransferDelivery")]
    public partial class TransferDelivery
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public int CarUserId { get; set; }

        public int StockOutUserId { get; set; }

        [Required]
        [StringLength(100)]
        public string Status { get; set; }

        public DateTime UpdateTime { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }
    }
}
