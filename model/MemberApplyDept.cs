namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberApplyDept")]
    public partial class MemberApplyDept
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int MemberId { get; set; }

        public int DeptId { get; set; }

        [Required]
        [StringLength(100)]
        public string DeptName { get; set; }

        [StringLength(100)]
        public string Code { get; set; }

        [StringLength(100)]
        public string PCode { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
