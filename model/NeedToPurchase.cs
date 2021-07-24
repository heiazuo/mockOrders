namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NeedToPurchase")]
    public partial class NeedToPurchase
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        public int Status { get; set; }

        public int PrintNum { get; set; }

        public int BranchId { get; set; }
    }
}
