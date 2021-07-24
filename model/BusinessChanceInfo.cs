namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessChanceInfo")]
    public partial class BusinessChanceInfo
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(500)]
        public string BusinessChangeName { get; set; }

        public int CustomerId { get; set; }

        public int Stage { get; set; }

        public decimal? Amount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PreDealDate { get; set; }

        [StringLength(255)]
        public string Note { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        public int? Director { get; set; }
    }
}
