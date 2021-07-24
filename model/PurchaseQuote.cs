namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseQuote")]
    public partial class PurchaseQuote
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int PurchaseId { get; set; }

        [StringLength(50)]
        public string DonvvBrandId { get; set; }

        [StringLength(100)]
        public string DonvvBrandName { get; set; }

        [StringLength(50)]
        public string DonvvSupplierId { get; set; }

        [StringLength(100)]
        public string DonvvSupplierName { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
