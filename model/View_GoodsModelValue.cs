namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_GoodsModelValue
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ModelId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ModelName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string Value { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrandId { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string SN { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(200)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(500)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParentId { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool IsEnable { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool IsWeb { get; set; }
    }
}
