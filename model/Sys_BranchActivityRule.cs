namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchActivityRule
    {
        public int Id { get; set; }

        public int ActivityId { get; set; }

        [Column(TypeName = "money")]
        public decimal RangeAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal DiscountAmount { get; set; }

        public int GiftMaxNum { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
