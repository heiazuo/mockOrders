namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product_Info
    {
        public int Id { get; set; }

        public int GoodsId { get; set; }

        public bool IsChecked { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Params { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(500)]
        public string SourceUrl { get; set; }
    }
}
