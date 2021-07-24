namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_VIPCounterDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CounterId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal VIPPrice { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Level { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool IsSales { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime AddTime { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(1000)]
        public string GoodsName { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Recommend { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(1000)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeId { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string Code { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(50)]
        public string PCode { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string TypeName { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsTypeLevel { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool IsEnable { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(500)]
        public string HomeImage { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StockNum { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool IsWeb { get; set; }
    }
}
