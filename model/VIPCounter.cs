namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VIPCounter")]
    public partial class VIPCounter
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Memo { get; set; }

        public int UserId { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public int GoodsNum { get; set; }

        public int CustomerNum { get; set; }
    }
}
