namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupOrderStatement")]
    public partial class GroupOrderStatement
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Column(TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Column(TypeName = "money")]
        public decimal PaidMoney { get; set; }

        [Required]
        [StringLength(50)]
        public string PayStatus { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }

        [Column(TypeName = "money")]
        public decimal ChargeOff { get; set; }
    }
}
