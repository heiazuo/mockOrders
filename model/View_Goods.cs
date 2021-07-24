namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Goods
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
        [StringLength(500)]
        public string SN { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1000)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1000)]
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FranchiseeId { get; set; }

        [StringLength(200)]
        public string FranchiseeName { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal InPrice { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Length { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Width { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Height { get; set; }

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
        [StringLength(50)]
        public string TypeName { get; set; }

        [StringLength(50)]
        public string PrivateTypeName { get; set; }

        [Key]
        [Column(Order = 33)]
        [StringLength(50)]
        public string Code { get; set; }

        [Key]
        [Column(Order = 34)]
        [StringLength(50)]
        public string PCode { get; set; }

        [Key]
        [Column(Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Level { get; set; }

        [Key]
        [Column(Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StockNum { get; set; }

        [Key]
        [Column(Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PointRate { get; set; }

        [Key]
        [Column(Order = 38)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 39)]
        [StringLength(500)]
        public string Feature { get; set; }

        [Key]
        [Column(Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MinimumQuantity { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string InnerId { get; set; }

        [Key]
        [Column(Order = 41)]
        public decimal Weight { get; set; }

        [Key]
        [Column(Order = 42)]
        [StringLength(50)]
        public string BrandName { get; set; }

        [Key]
        [Column(Order = 43)]
        [StringLength(100)]
        public string FullName { get; set; }

        [Key]
        [Column(Order = 44)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhotoNum { get; set; }

        [Key]
        [Column(Order = 45)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DetailPhotoNum { get; set; }

        [StringLength(200)]
        public string Model { get; set; }

        [Key]
        [Column(Order = 46)]
        public bool IsPublic { get; set; }

        [Key]
        [Column(Order = 47)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DonvvSKU { get; set; }

        [Key]
        [Column(Order = 48)]
        public bool ForbidWebOrderByNoStock { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        [StringLength(50)]
        public string Tpn { get; set; }

        [StringLength(500)]
        public string TPName { get; set; }

        [StringLength(50)]
        public string TaxCode { get; set; }

        public int? DataSource { get; set; }

        [Key]
        [Column(Order = 49)]
        [StringLength(200)]
        public string Tags { get; set; }

        [Key]
        [Column(Order = 50)]
        public bool GoodsTypeDisable { get; set; }

        [Key]
        [Column(Order = 51)]
        [StringLength(50)]
        public string SalesAnalysis { get; set; }

        public bool? IsAddDeviceCode { get; set; }
    }
}
