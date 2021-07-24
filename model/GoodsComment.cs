namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsComment")]
    public partial class GoodsComment
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int GoodsId { get; set; }

        public int MemberId { get; set; }

        public int Level { get; set; }

        [StringLength(100)]
        public string Label { get; set; }

        [StringLength(1000)]
        public string Content { get; set; }

        public DateTime? OrderTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
