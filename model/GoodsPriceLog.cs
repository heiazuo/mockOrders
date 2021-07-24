namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsPriceLog")]
    public partial class GoodsPriceLog
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int GoodsId { get; set; }

        [Column(TypeName = "money")]
        public decimal OldPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal NewPrice { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
