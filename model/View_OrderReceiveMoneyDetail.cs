namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_OrderReceiveMoneyDetail
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
        public int OrderId { get; set; }

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
        public decimal Price { get; set; }

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

        [StringLength(500)]
        public string GoodsName { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderStatementId { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "money")]
        public decimal ReceiveMoney { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string PayType { get; set; }

        public DateTime? ReceiveDate { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(200)]
        public string CustomerName { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(50)]
        public string UserName { get; set; }

        public int? ReceiveAccountId { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ODNum { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ODPickNum { get; set; }

        [StringLength(300)]
        public string ReceiveAccount { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }
    }
}
