namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_ORMAudit
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderStatementId { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal ReceiveMoney { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal DiscountMoney { get; set; }

        public DateTime? ReceiveDate { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string PayType { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(200)]
        public string CustomerName { get; set; }

        [StringLength(100)]
        public string ShortName { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesId { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServiceId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string PayStatus { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "money")]
        public decimal PaidMoney { get; set; }

        public int? BankInfoId { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [StringLength(302)]
        public string bankinfo { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(1000)]
        public string Remark { get; set; }

        [StringLength(50)]
        public string ApproveUser { get; set; }

        public DateTime? FinanceAuditUpdateTime { get; set; }
    }
}
