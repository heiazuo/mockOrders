namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_OrderDetail
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string I_OrderId { get; set; }

        public int GoodsId { get; set; }

        public int Num { get; set; }

        [Required]
        [StringLength(50)]
        public string Unit { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }
    }
}
