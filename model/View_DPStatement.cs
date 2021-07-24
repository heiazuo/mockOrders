namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_DPStatement
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [StringLength(100)]
        public string BranchName { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierId { get; set; }

        [StringLength(100)]
        public string SupplierName { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal PaidMoney { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string PayStatus { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal InvoiceMoney { get; set; }

        [StringLength(50)]
        public string InvoiceStatus { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UpdateBy { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime UpdateAt { get; set; }

        [StringLength(50)]
        public string UpdateByName { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal PaidApplyMoney { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "money")]
        public decimal InvoiceApplyMoney { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "money")]
        public decimal InvoiceChargeOff { get; set; }
    }
}
