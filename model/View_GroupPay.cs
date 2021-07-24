namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_GroupPay
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
        public decimal PayMoney { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string PayType { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime PayDate { get; set; }

        [StringLength(200)]
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
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal SumMoney { get; set; }
    }
}
