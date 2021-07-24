namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_SupplierReceiveInvoice
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierId { get; set; }

        [StringLength(200)]
        public string SupplierName { get; set; }

        public DateTime? LastTimeSADate { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal LastTimeSABalance { get; set; }

        [Column(TypeName = "money")]
        public decimal? PurchaseAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? PurchasePayAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAmount { get; set; }
    }
}
