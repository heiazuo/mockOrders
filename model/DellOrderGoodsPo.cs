namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DellOrderGoodsPo")]
    public partial class DellOrderGoodsPo
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int OrderId { get; set; }

        public int OrderDetailId { get; set; }

        [StringLength(50)]
        public string PO { get; set; }

        public int? GoodsId { get; set; }

        [StringLength(500)]
        public string GoodsName { get; set; }

        public int? GoodsNum { get; set; }

        [Column(TypeName = "money")]
        public decimal? GoodsPrice { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
