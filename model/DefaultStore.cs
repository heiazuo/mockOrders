namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DefaultStore")]
    public partial class DefaultStore
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Place { get; set; }

        [StringLength(100)]
        public string OrderType { get; set; }

        public DateTime UpdateTime { get; set; }

        public int StoreId { get; set; }
    }
}
