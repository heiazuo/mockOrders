namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchSiteSetting
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(100)]
        public string SiteName { get; set; }

        [Required]
        [StringLength(500)]
        public string LogoUrl { get; set; }

        [Required]
        [StringLength(50)]
        public string Telphone { get; set; }

        public bool UseGoodsTypes { get; set; }

        public bool UseTopMenus { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(200)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(300)]
        public string CompanyAddress { get; set; }

        [StringLength(500)]
        public string ICP_No { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyTelphone { get; set; }

        public bool IsShowSubGoods { get; set; }

        public bool UseQQCustomer { get; set; }

        [Required]
        [StringLength(20)]
        public string QQ { get; set; }

        [Required]
        [StringLength(500)]
        public string IconUrl { get; set; }

        [StringLength(20)]
        public string VerificationCodeName { get; set; }

        [Required]
        [StringLength(500)]
        public string ContactImage { get; set; }

        [Required]
        public string HtmlValidate { get; set; }

        [StringLength(500)]
        public string Qrcode { get; set; }

        [StringLength(100)]
        public string SubTelphone { get; set; }
    }
}
