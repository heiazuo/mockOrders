namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_OrderModifyAC
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ModifyACId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal GrossProfit { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal NewGrossProfit { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "money")]
        public decimal Amount { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal OldAC { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal NewAC { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(50)]
        public string OldGrossProfitPercent { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string NewGrossProfitPercent { get; set; }

        [Key]
        [Column(Order = 14)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(500)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }
    }
}
