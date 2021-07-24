namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsPackageLog")]
    public partial class GoodsPackageLog
    {
        public int Id { get; set; }

        public int GoodsId { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public int OldNum { get; set; }

        public int Num { get; set; }

        [StringLength(10)]
        public string OldName { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int IsDefault { get; set; }

        [StringLength(10)]
        public string OldBarCode { get; set; }

        [Required]
        [StringLength(100)]
        public string BarCode { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
