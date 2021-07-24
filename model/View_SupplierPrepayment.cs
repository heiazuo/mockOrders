namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_SupplierPrepayment
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

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string SupplierName { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PurchaseStatementId { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal InitialBalance { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string Operate { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal Prepayment { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal Payment { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "money")]
        public decimal Balance { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OperatorId { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string OperatorName { get; set; }

        [Column(TypeName = "text")]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string PayType { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string PayAccount { get; set; }

        [Key]
        [Column(Order = 15)]
        public DateTime ActualPayTime { get; set; }

        [StringLength(302)]
        public string BankInfo { get; set; }
    }
}
