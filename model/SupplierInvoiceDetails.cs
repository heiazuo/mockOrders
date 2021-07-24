namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SupplierInvoiceDetails
    {
        public int Id { get; set; }

        public int SupplierInvoiceId { get; set; }

        public int PurchaseId { get; set; }

        public int SupplierId { get; set; }

        [Required]
        [StringLength(100)]
        public string SupplierName { get; set; }

        public int GoodsId { get; set; }

        [StringLength(500)]
        public string DisplayName { get; set; }

        [Column(TypeName = "money")]
        public decimal? InPrice { get; set; }

        public int Num { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public DateTime AddTime { get; set; }

        public int InvoicedNum { get; set; }

        [Column(TypeName = "money")]
        public decimal? ToInvoiceMoney { get; set; }

        public int BranchId { get; set; }

        public bool IsDelete { get; set; }
    }
}
