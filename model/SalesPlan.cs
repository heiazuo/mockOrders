namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesPlan")]
    public partial class SalesPlan
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int CustomerId { get; set; }

        [Required]
        [StringLength(500)]
        public string Customer { get; set; }

        public int SalesId { get; set; }

        [Required]
        [StringLength(50)]
        public string SalesName { get; set; }

        [Column(TypeName = "date")]
        public DateTime PlanDate { get; set; }

        [Column(TypeName = "money")]
        public decimal PlanMoney { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Column(TypeName = "text")]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
