namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_SupplierInvoice
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierId { get; set; }

        [StringLength(200)]
        public string SupplierName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [StringLength(50)]
        public string SysUserName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string InvoiceType { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(500)]
        public string InvoiceName { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string InvoiceCode { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string InvoiceNo { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal InvoiceMoney { get; set; }

        [Key]
        [Column(Order = 9)]
        public string Content { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime InvoiceDate { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(500)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime ReceiveDate { get; set; }

        [Key]
        [Column(Order = 13)]
        public DateTime UpdateTime { get; set; }
    }
}
