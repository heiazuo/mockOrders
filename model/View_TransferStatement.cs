namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_TransferStatement
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
        [Column(Order = 2, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal PaidMoney { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string PayStatus { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(100)]
        public string BranchName { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string UserName { get; set; }
    }
}
