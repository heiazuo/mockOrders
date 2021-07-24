namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderModifyAC")]
    public partial class OrderModifyAC
    {
        public int Id { get; set; }

        public int ModifyACId { get; set; }

        public int OrderId { get; set; }

        [Column(TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Column(TypeName = "money")]
        public decimal GrossProfit { get; set; }

        [Column(TypeName = "money")]
        public decimal NewGrossProfit { get; set; }

        public int GoodsId { get; set; }

        public int Num { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public decimal OldAC { get; set; }

        public decimal NewAC { get; set; }

        [Required]
        [StringLength(50)]
        public string OldGrossProfitPercent { get; set; }

        [Required]
        [StringLength(50)]
        public string NewGrossProfitPercent { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
