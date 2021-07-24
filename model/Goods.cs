namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Goods
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Guid { get; set; }

        public int BranchId { get; set; }

        public int TypeId { get; set; }

        public int BrandId { get; set; }

        [Required]
        [StringLength(500)]
        public string SN { get; set; }

        [Required]
        [StringLength(1000)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        public string DisplayName { get; set; }

        [Required]
        [StringLength(500)]
        public string PY { get; set; }

        [Required]
        [StringLength(50)]
        public string Unit { get; set; }

        public decimal Price { get; set; }

        public decimal InPrice { get; set; }

        public int Length { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public decimal Weight { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string PackingList { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Service { get; set; }

        public int Recommend { get; set; }

        public DateTime RecommendDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal cuxiao { get; set; }

        public DateTime cuxiaoDate { get; set; }

        public int Rate { get; set; }

        [Required]
        [StringLength(500)]
        public string HomeImage { get; set; }

        public bool IsEnable { get; set; }

        public bool IsWeb { get; set; }

        [Required]
        [StringLength(50)]
        public string CombinationType { get; set; }

        public int ParentId { get; set; }

        public int SaleNumber { get; set; }

        public int SaleCount { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public int StockNum { get; set; }

        [Required]
        [StringLength(500)]
        public string Feature { get; set; }

        public int UserId { get; set; }

        [StringLength(50)]
        public string InnerId { get; set; }

        public int PhotoNum { get; set; }

        public int DetailPhotoNum { get; set; }

        [StringLength(200)]
        public string Model { get; set; }

        public bool IsPublic { get; set; }

        public int DonvvSKU { get; set; }

        public int MinimumQuantity { get; set; }

        [Required]
        [StringLength(50)]
        public string SalesAnalysis { get; set; }

        public bool ForbidWebOrderByNoStock { get; set; }

        public decimal? PriceExtend { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        public int FranchiseeId { get; set; }

        [StringLength(50)]
        public string Tpn { get; set; }

        [StringLength(500)]
        public string TPName { get; set; }

        [StringLength(50)]
        public string TaxCode { get; set; }

        public int? DataSource { get; set; }

        [Required]
        [StringLength(200)]
        public string Tags { get; set; }

        public bool? IsAddDeviceCode { get; set; }

        public int? ArrivalDays { get; set; }
    }
}
