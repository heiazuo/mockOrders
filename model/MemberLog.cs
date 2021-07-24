namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberLog")]
    public partial class MemberLog
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int CustomerId { get; set; }

        public int MemberId { get; set; }

        [Required]
        [StringLength(50)]
        public string MemberName { get; set; }

        public int Operate { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }

        public string Tracking { get; set; }

        [StringLength(200)]
        public string CustomerName { get; set; }
    }
}
