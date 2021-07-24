namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailInvoiceSetting")]
    public partial class EmailInvoiceSetting
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [StringLength(200)]
        public string PlatIdentity { get; set; }

        [Required]
        [StringLength(200)]
        public string SaleName { get; set; }

        [Required]
        [StringLength(200)]
        public string SaleBank { get; set; }

        [Required]
        [StringLength(100)]
        public string SaleBankAccount { get; set; }

        [Required]
        [StringLength(20)]
        public string SaleTaxNum { get; set; }

        [Required]
        [StringLength(20)]
        public string SalePhone { get; set; }

        [Required]
        [StringLength(80)]
        public string SaleAddress { get; set; }

        [Required]
        public string PlatAPI { get; set; }

        public bool IsEnable { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime UpdateTime { get; set; }

        [StringLength(500)]
        public string AppKey { get; set; }

        [StringLength(500)]
        public string AppSecret { get; set; }

        [StringLength(500)]
        public string Token { get; set; }

        public long? ExpiresTime { get; set; }

        public int? Plat { get; set; }
    }
}
