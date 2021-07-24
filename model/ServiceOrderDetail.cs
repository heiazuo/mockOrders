namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceOrderDetail")]
    public partial class ServiceOrderDetail
    {
        public int Id { get; set; }

        public int ServiceId { get; set; }

        public int? OrderId { get; set; }

        public int? ItemId { get; set; }

        public int? GoodsId { get; set; }

        [Required]
        [StringLength(200)]
        public string GoodsName { get; set; }

        public int Num { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        [Required]
        [StringLength(50)]
        public string Unit { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
    }
}
