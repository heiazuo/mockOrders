namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Open_SyncData
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int Type { get; set; }

        public int ItemId { get; set; }

        [StringLength(50)]
        public string ItemCode { get; set; }

        [StringLength(255)]
        public string ExtendName { get; set; }

        [StringLength(255)]
        public string Extend { get; set; }

        public DateTime CreateAt { get; set; }
    }
}
