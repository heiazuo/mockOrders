namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplierPrepayment")]
    public partial class SupplierPrepayment
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int SupplierId { get; set; }

        [Required]
        [StringLength(200)]
        public string SupplierName { get; set; }

        public int PurchaseStatementId { get; set; }

        [Column(TypeName = "money")]
        public decimal InitialBalance { get; set; }

        [Required]
        [StringLength(10)]
        public string Operate { get; set; }

        [Column(TypeName = "money")]
        public decimal Prepayment { get; set; }

        [Column(TypeName = "money")]
        public decimal Payment { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        public int OperatorId { get; set; }

        [Required]
        [StringLength(50)]
        public string OperatorName { get; set; }

        [Column(TypeName = "text")]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string PayType { get; set; }

        [Required]
        [StringLength(50)]
        public string PayAccount { get; set; }

        public DateTime ActualPayTime { get; set; }
    }
}
