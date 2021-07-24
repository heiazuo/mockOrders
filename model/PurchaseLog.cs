namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseLog")]
    public partial class PurchaseLog
    {
        public int Id { get; set; }

        public int PurchaseId { get; set; }

        [Required]
        [StringLength(50)]
        public string PurchaseType { get; set; }

        [Column(TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Required]
        [StringLength(50)]
        public string PurchaseStatus { get; set; }

        [Column(TypeName = "text")]
        public string Memo { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(200)]
        public string Operate { get; set; }

        public bool IsInner { get; set; }
    }
}
