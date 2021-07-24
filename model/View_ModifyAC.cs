namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_ModifyAC
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal OldInPrice { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal OldAC { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool ModifyGoodsInPrice { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal NewInPrice { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool ModifyInventoryAC { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StockNum { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ModifyOrderDetailAC { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderCount { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal NewAC { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [StringLength(1000)]
        public string Memo { get; set; }

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
        public string UserName { get; set; }
    }
}
