namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_GoodsLog
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int I_ProjectId { get; set; }

        public int GoodsId { get; set; }

        [Required]
        [StringLength(500)]
        public string GoodsName { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(50)]
        public string Unit { get; set; }

        public int Num { get; set; }

        public bool IsEnable { get; set; }

        public decimal Discount { get; set; }

        [Column(TypeName = "money")]
        public decimal? MarketPrice { get; set; }

        [Required]
        [StringLength(500)]
        public string Operate { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        public DateTime OperateTime { get; set; }

        public string Memo { get; set; }
    }
}
