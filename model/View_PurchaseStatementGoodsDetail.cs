namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_PurchaseStatementGoodsDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PurchaseStatementId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PurchaseId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal InPrice { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal Amount { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceivedNum { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool IsEmergency { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierNum { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "date")]
        public DateTime DelayDate { get; set; }

        [StringLength(50)]
        public string PurchaseStatus { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime PurchaseDate { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string PurchaseType { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierId { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(500)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 15)]
        public decimal Price { get; set; }

        [StringLength(20)]
        public string InvoiceType { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "money")]
        public decimal TaxRate { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "money")]
        public decimal NoTaxInPrice { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "money")]
        public decimal TaxAmount { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "money")]
        public decimal NoTaxAmount { get; set; }

        [StringLength(50)]
        public string TaxCode { get; set; }
    }
}
