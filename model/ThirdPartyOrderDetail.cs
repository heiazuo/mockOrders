namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThirdPartyOrderDetail")]
    public partial class ThirdPartyOrderDetail
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(64)]
        public string ThirdPartyOrderId { get; set; }

        [Required]
        [StringLength(64)]
        public string SkuId { get; set; }

        public long CategoryId { get; set; }

        [Required]
        [StringLength(128)]
        public string SkuName { get; set; }

        public int SkuNum { get; set; }

        public decimal Price { get; set; }

        [Required]
        [StringLength(32)]
        public string Unit { get; set; }

        [Required]
        [StringLength(32)]
        public string BrandName { get; set; }

        [StringLength(64)]
        public string SN { get; set; }

        [StringLength(500)]
        public string PackingList { get; set; }

        [StringLength(500)]
        public string Introduction { get; set; }

        [StringLength(64)]
        public string BarCode { get; set; }

        [StringLength(500)]
        public string PrimaryImage { get; set; }
    }
}
