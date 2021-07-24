namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Contract")]
    public partial class Contract
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string ContractNo { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        public int CustomerId { get; set; }

        [StringLength(500)]
        public string CustomerName { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public DateTime? StartAt { get; set; }

        public DateTime? EndAt { get; set; }

        public DateTime? CreateAt { get; set; }

        [StringLength(1000)]
        public string Remark { get; set; }

        [StringLength(100)]
        public string Signer { get; set; }

        [StringLength(100)]
        public string SalesUser { get; set; }

        [StringLength(1000)]
        public string FileUrl { get; set; }

        public int BranchId { get; set; }
    }
}
