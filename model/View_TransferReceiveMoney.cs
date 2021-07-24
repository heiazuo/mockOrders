namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_TransferReceiveMoney
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TransferStatementId { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal ReceiveMoney { get; set; }

        public DateTime? ReceiveDate { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string PayType { get; set; }

        [StringLength(200)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string PayStatus { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal PaidMoney { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(100)]
        public string BranchName { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }
    }
}
