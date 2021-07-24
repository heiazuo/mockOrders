namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDistributionDetail")]
    public partial class OrderDistributionDetail
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int GoodsId { get; set; }

        public int OrderDistributionId { get; set; }

        public int Num { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool IsDelete { get; set; }
    }
}
