namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsModelValue")]
    public partial class GoodsModelValue
    {
        public int Id { get; set; }

        public int GoodsId { get; set; }

        public int ModelId { get; set; }

        [Required]
        [StringLength(100)]
        public string Value { get; set; }

        public DateTime UpdateTime { get; set; }

        public int? SortNumber { get; set; }
    }
}
