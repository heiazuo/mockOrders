namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GoodsExtensions
    {
        public int Id { get; set; }

        public int GoodsId { get; set; }

        [Column(TypeName = "text")]
        public string Remark { get; set; }

        public int? VirtualSales { get; set; }
    }
}
