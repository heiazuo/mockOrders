namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_IGoods
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int I_ProjectId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 3)]
        public decimal OriginalPrice { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool IsEnable { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(1000)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal Discount { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeId { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string Code { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string PCode { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal Weight { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(500)]
        public string HomeImage { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool GoodsEnable { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrandId { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(100)]
        public string BrandName { get; set; }

        public bool? IsNeededPush { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(50)]
        public string GoodsTypeName { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(200)]
        public string Model { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool IsWeb { get; set; }

        [Column(TypeName = "money")]
        public decimal? MarketPrice { get; set; }

        public bool? IsModify { get; set; }

        public int? StockNum { get; set; }

        [StringLength(50)]
        public string OperateUser { get; set; }

        [Key]
        [Column(Order = 23)]
        public DateTime OperateTime { get; set; }
    }
}
