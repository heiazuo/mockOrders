namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_SupplierOrder
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string BranchName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string ShortName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PurchaseId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NeedToPurchaseId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierId { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string PurchaseType { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime PurchaseDate { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string PayStatus { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceiptUserId { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 13)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string SupplierStatus { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }
    }
}
