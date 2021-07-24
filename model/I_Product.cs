namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_Product
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int ServerId { get; set; }

        [Required]
        [StringLength(500)]
        public string AppKey { get; set; }

        [Required]
        [StringLength(500)]
        public string AppSecret { get; set; }

        [StringLength(500)]
        public string Token { get; set; }

        public long? ExpiredTime { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
