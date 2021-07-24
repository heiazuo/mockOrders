namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessFollowRecord")]
    public partial class BusinessFollowRecord
    {
        public int Id { get; set; }

        public int BusinessId { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(500)]
        public string BusinessChangeName { get; set; }

        public int CustomerId { get; set; }

        public string Content { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FollowTime { get; set; }

        [StringLength(500)]
        public string Picture { get; set; }

        [StringLength(500)]
        public string FileUrl { get; set; }
    }
}
