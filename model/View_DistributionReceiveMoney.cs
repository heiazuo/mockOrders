namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_DistributionReceiveMoney
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
        public int PBranchId { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal ReceiveMoney { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime ReceiveDate { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string PayType { get; set; }

        public int? ReceiveAccount { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(100)]
        public string PBranchName { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(302)]
        public string BankInfo { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool IsDelete { get; set; }
    }
}
