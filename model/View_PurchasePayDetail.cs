namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_PurchasePayDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PayId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PurchaseId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal InPrice { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal Amount { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal ChargeOffAmount { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool IsDelete { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(500)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PurchaseStatementId { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "money")]
        public decimal PayMoney { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(50)]
        public string PayType { get; set; }

        [Key]
        [Column(Order = 16)]
        public DateTime PayDate { get; set; }

        [StringLength(200)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierId { get; set; }

        [StringLength(200)]
        public string SupplierName { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(50)]
        public string UserName { get; set; }

        public int? PayAccountId { get; set; }

        [StringLength(50)]
        public string PurchaseStatus { get; set; }

        [StringLength(300)]
        public string PayAccount { get; set; }
    }
}
