namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_DistributionPayDetail
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
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ChildBranchId { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal PayMoney { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime PayDate { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string PayType { get; set; }

        public int? PayAccount { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(100)]
        public string ChildBranchName { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "money")]
        public decimal Amount { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "money")]
        public decimal ChargeOffAmount { get; set; }

        [Key]
        [Column(Order = 16)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(500)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(50)]
        public string Unit { get; set; }

        [StringLength(302)]
        public string BankInfo { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool IsDelete { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatementId { get; set; }
    }
}
