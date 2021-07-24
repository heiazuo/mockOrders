namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerCategory")]
    public partial class CustomerCategory
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [StringLength(500)]
        public string Cus_Type { get; set; }

        public DateTime? AddTime { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
