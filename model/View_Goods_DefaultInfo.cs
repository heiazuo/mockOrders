namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Goods_DefaultInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Guid { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrandId { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string SN { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(200)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(500)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(500)]
        public string PY { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal InPrice { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Length { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Width { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Height { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal Weight { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "text")]
        public string PackingList { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "text")]
        public string Service { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Recommend { get; set; }

        [Key]
        [Column(Order = 19)]
        public DateTime RecommendDate { get; set; }

        [Key]
        [Column(Order = 20, TypeName = "numeric")]
        public decimal cuxiao { get; set; }

        [Key]
        [Column(Order = 21)]
        public DateTime cuxiaoDate { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rate { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(500)]
        public string HomeImage { get; set; }

        [Key]
        [Column(Order = 24)]
        public bool IsEnable { get; set; }

        [Key]
        [Column(Order = 25)]
        public bool IsWeb { get; set; }

        [Key]
        [Column(Order = 26)]
        [StringLength(50)]
        public string CombinationType { get; set; }

        [Key]
        [Column(Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParentId { get; set; }

        [Key]
        [Column(Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SaleNumber { get; set; }

        [Key]
        [Column(Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SaleCount { get; set; }

        [Key]
        [Column(Order = 30)]
        public DateTime AddTime { get; set; }

        [Key]
        [Column(Order = 31)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StockNum { get; set; }

        [Key]
        [Column(Order = 33)]
        [StringLength(500)]
        public string Feature { get; set; }

        [Key]
        [Column(Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [StringLength(50)]
        public string InnerId { get; set; }

        [Key]
        [Column(Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhotoNum { get; set; }

        [Key]
        [Column(Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DetailPhotoNum { get; set; }

        [Key]
        [Column(Order = 37)]
        [StringLength(50)]
        public string Model { get; set; }

        [Key]
        [Column(Order = 38)]
        public bool IsPublic { get; set; }

        [Key]
        [Column(Order = 39)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DonvvSKU { get; set; }

        [Key]
        [Column(Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MinimumQuantity { get; set; }

        [Key]
        [Column(Order = 41)]
        [StringLength(50)]
        public string SalesAnalysis { get; set; }

        public int? GDIId { get; set; }

        public int? GoodsId { get; set; }

        public int? PurchaseUserId { get; set; }

        public int? AddUserId { get; set; }

        public DateTime? GDIUpdateTime { get; set; }

        public DateTime? GDIAddTime { get; set; }

        [StringLength(50)]
        public string PurchaseUserName { get; set; }

        [StringLength(50)]
        public string AddUserName { get; set; }
    }
}
