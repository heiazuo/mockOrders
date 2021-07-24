namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchPay
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int PaymentId { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(500)]
        public string AppId { get; set; }

        [StringLength(500)]
        public string PartnerId { get; set; }

        [StringLength(3000)]
        public string Secret { get; set; }

        [StringLength(3000)]
        public string AppSecret { get; set; }

        [StringLength(3000)]
        public string Public_key { get; set; }

        [StringLength(500)]
        public string Sslcert_path { get; set; }

        public int? Sort { get; set; }

        public DateTime? AddTime { get; set; }

        [StringLength(500)]
        public string CertFileUrl { get; set; }

        [StringLength(100)]
        public string BizType { get; set; }
    }
}
