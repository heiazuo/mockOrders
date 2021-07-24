namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Approve
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string KeyId { get; set; }

        [StringLength(100)]
        public string ApproveKey { get; set; }

        [StringLength(100)]
        public string ApproveAccount { get; set; }

        public int? ApproveMethod { get; set; }

        public int? ApproveType { get; set; }

        public DateTime? ApproveAt { get; set; }

        [StringLength(50)]
        public string ApproveCode { get; set; }

        public int? ApproveCount { get; set; }

        public int? ApproveLimit { get; set; }

        public bool? ApproveValid { get; set; }

        public DateTime? CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
