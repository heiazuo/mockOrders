namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchAuth
    {
        public int Id { get; set; }

        public int ServerId { get; set; }

        public int BranchId { get; set; }

        [StringLength(3000)]
        public string AppKey { get; set; }

        [StringLength(3000)]
        public string AppSecret { get; set; }

        [StringLength(500)]
        public string Token { get; set; }

        public long? ExpiresTime { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
