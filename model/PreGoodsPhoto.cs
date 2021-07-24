namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PreGoodsPhoto")]
    public partial class PreGoodsPhoto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string GoodsId { get; set; }

        [StringLength(100)]
        public string PhotoUrl { get; set; }

        public bool? IsHomeImage { get; set; }

        public bool? IsDetailPhoto { get; set; }
    }
}
