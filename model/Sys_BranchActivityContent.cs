namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchActivityContent
    {
        public int Id { get; set; }

        public int ActivityId { get; set; }

        public int Type { get; set; }

        [StringLength(200)]
        public string Url { get; set; }

        public int Sort { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
