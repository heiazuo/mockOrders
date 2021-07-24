namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SupplierSettleAccounts
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int SupplierId { get; set; }

        public int UserId { get; set; }

        public DateTime LastTimeSADate { get; set; }

        public DateTime SettleAccountDate { get; set; }

        [Column(TypeName = "money")]
        public decimal PurchaseAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal PurchasePayAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal InvoiceAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal LastTimeBalance { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        [Required]
        [StringLength(500)]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
