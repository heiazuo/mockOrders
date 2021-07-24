namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_ChengDuCategoryExt
    {
        public int Id { get; set; }

        public int? BranchId { get; set; }

        [StringLength(100)]
        public string Code { get; set; }

        public decimal? Discount { get; set; }

        [Column(TypeName = "money")]
        public decimal? Summoney { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
