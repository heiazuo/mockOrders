namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_GoodsMap
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }

        [Required]
        [StringLength(500)]
        public string ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public string ProductUrl { get; set; }

        public int SkuId { get; set; }

        [Required]
        public string ProductNameEC { get; set; }

        [Required]
        public string ProductUrlEC { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
