namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsCaptcha")]
    public partial class GoodsCaptcha
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int GoodsId { get; set; }

        [Required]
        [StringLength(500)]
        public string Captcha { get; set; }

        public int BranchId { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
