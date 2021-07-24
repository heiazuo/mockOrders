namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_SupplierSettleAccounts
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
        public DateTime LastTimeSADate { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime SettleAccountDate { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal PurchaseAmount { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal PurchasePayAmount { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal InvoiceAmount { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "money")]
        public decimal LastTimeBalance { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal Balance { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(500)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime UpdateTime { get; set; }
    }
}
