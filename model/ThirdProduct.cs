namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThirdProduct")]
    public partial class ThirdProduct
    {
        public int id { get; set; }

        [Required]
        [StringLength(500)]
        public string product_code { get; set; }

        [Required]
        [StringLength(500)]
        public string source { get; set; }

        public int goodsId { get; set; }

        public string introduction { get; set; }

        public DateTime addTime { get; set; }

        public DateTime? finishTime { get; set; }

        public int? PhotoNum { get; set; }

        public int? DetailPhotoNum { get; set; }
    }
}
