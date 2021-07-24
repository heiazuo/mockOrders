namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_FinanceRecord
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
        public int BankId { get; set; }

        [StringLength(1000)]
        public string BankInfo { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal InitBalance { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal OperateAmount { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal Balance { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(200)]
        public string Operate { get; set; }

        [StringLength(200)]
        public string PayType { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DebtorId { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LenderId { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(500)]
        public string DebtorName { get; set; }

        [Key]
        [Column(Order = 10)]
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

        [StringLength(50)]
        public string SalesName { get; set; }
    }
}
