namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_DistributionCustomerReceiveMoneyDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceiveMoneyId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string CustomerName { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string Operate { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal ReceiveMoney { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime ReceiveDate { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string PayType { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatementId { get; set; }

        public int? ReceiveAccount { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(100)]
        public string BranchName { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "money")]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "money")]
        public decimal Amount { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "money")]
        public decimal ChargeOffAmount { get; set; }

        [Key]
        [Column(Order = 19)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(200)]
        public string GoodsName { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(50)]
        public string Unit { get; set; }

        [StringLength(302)]
        public string BankInfo { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool MoneyDetailIsDelete { get; set; }

        [Key]
        [Column(Order = 23)]
        public bool MoneyIsDelete { get; set; }
    }
}
