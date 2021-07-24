namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchActivityRange
    {
        public int Id { get; set; }

        public int ActivityId { get; set; }

        public int ItemType { get; set; }

        public int ItemId { get; set; }

        [StringLength(100)]
        public string ItemCode { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
