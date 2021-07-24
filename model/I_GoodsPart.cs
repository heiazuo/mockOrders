namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_GoodsPart
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int ProjectId { get; set; }

        public int GoodsId { get; set; }

        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public DateTime? UpdateAt { get; set; }

        public int? Type { get; set; }
    }
}
