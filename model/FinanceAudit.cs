namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FinanceAudit")]
    public partial class FinanceAudit
    {
        public int Id { get; set; }

        public int? BranchId { get; set; }

        public int? FinanceId { get; set; }

        public int? UserId { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(1000)]
        public string Remark { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public DateTime? UpdateTime { get; set; }

        [Column(TypeName = "text")]
        public string FinanceData { get; set; }
    }
}
