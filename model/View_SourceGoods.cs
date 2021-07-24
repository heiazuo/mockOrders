namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_SourceGoods
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
        public int SourceId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(500)]
        public string Url { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string SourceSku { get; set; }

        [StringLength(200)]
        public string SourceMainSku { get; set; }

        [StringLength(200)]
        public string SpecVals { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(200)]
        public string SourceCategory { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(200)]
        public string SourceBrand { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal SourcePrice { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TargetParentId { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TargetGoodsId { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DataSource { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(1000)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(200)]
        public string SN { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeId { get; set; }

        [StringLength(50)]
        public string TypeName { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrandId { get; set; }

        [StringLength(100)]
        public string BrandName { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 17)]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhotoNum { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DetailPhotoNum { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool IsEnable { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(50)]
        public string CombinationType { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(50)]
        public string Model { get; set; }
    }
}
