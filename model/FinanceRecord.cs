namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FinanceRecord")]
    public partial class FinanceRecord
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int BankId { get; set; }

        [StringLength(1000)]
        public string BankInfo { get; set; }

        [Column(TypeName = "money")]
        public decimal InitBalance { get; set; }

        [Column(TypeName = "money")]
        public decimal OperateAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        [Required]
        [StringLength(200)]
        public string Operate { get; set; }

        [StringLength(200)]
        public string PayType { get; set; }

        public int DebtorId { get; set; }

        public int LenderId { get; set; }

        [Required]
        [StringLength(500)]
        public string DebtorName { get; set; }

        [Required]
        [StringLength(500)]
        public string LenderName { get; set; }

        [StringLength(500)]
        public string SubjectCode { get; set; }

        [StringLength(500)]
        public string SubjectName { get; set; }

        [StringLength(500)]
        public string Tpn { get; set; }

        [StringLength(4000)]
        public string Remark { get; set; }

        public DateTime? OpreteDate { get; set; }

        public DateTime? AddAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        public int? SalesId { get; set; }
    }
}
