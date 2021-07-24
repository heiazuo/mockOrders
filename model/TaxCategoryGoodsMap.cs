namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaxCategoryGoodsMap")]
    public partial class TaxCategoryGoodsMap
    {
        public int Id { get; set; }

        public int TaxCategoryId { get; set; }

        public int GoodsId { get; set; }

        public int BranchId { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
