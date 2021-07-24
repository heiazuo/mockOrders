namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_GoodsPackage
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Type { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsDefault { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string BarCode { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string CombinationType { get; set; }

        [StringLength(100)]
        public string DonvvSpuCode { get; set; }

        [StringLength(100)]
        public string DonvvSkuCode { get; set; }
    }
}
