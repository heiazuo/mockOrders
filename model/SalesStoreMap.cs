namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesStoreMap")]
    public partial class SalesStoreMap
    {
        public int Id { get; set; }

        public int? BranchId { get; set; }

        public int? SalesNo { get; set; }

        [StringLength(50)]
        public string SalesName { get; set; }

        public int? StoreId { get; set; }

        [StringLength(50)]
        public string StoreName { get; set; }

        public DateTime? UpdateTime { get; set; }

        public bool? IsEnable { get; set; }
    }
}
