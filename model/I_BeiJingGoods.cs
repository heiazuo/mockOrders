namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_BeiJingGoods
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string I_ProductId { get; set; }

        [StringLength(255)]
        public string I_Category { get; set; }

        [StringLength(255)]
        public string I_Brand { get; set; }

        [StringLength(500)]
        public string I_ProductName { get; set; }

        public decimal? I_SalePrice { get; set; }
    }
}
