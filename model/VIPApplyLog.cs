namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VIPApplyLog")]
    public partial class VIPApplyLog
    {
        public int Id { get; set; }

        public int ApplyId { get; set; }

        public int ApplyUserId { get; set; }

        public int OperatorId { get; set; }

        [Required]
        [StringLength(10)]
        public string OperateStatus { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
