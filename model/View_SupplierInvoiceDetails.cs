namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_SupplierInvoiceDetails
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierInvoiceId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PurchaseId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string SupplierName { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string InvoiceType { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [StringLength(500)]
        public string DisplayName { get; set; }

        [Column(TypeName = "money")]
        public decimal? InPrice { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime AddTime { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InvoicedNum { get; set; }

        [Column(TypeName = "money")]
        public decimal? ToInvoiceMoney { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool IsDelete { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string Unit { get; set; }

        [StringLength(50)]
        public string PurchaseStatus { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime PutInStoreTime { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(20)]
        public string InvoiceCode { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string InvoiceNo { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string UserName { get; set; }
    }
}
