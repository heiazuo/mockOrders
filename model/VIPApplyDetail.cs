namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VIPApplyDetail")]
    public partial class VIPApplyDetail
    {
        public int Id { get; set; }

        public int ApplyId { get; set; }

        public int GoodsId { get; set; }

        public int Num { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public int DisplayNum { get; set; }

        [Required]
        [StringLength(50)]
        public string DisplayUnit { get; set; }

        [Column(TypeName = "money")]
        public decimal DisplayPrice { get; set; }
    }
}
