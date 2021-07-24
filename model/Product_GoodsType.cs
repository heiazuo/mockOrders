namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product_GoodsType
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int TypeId { get; set; }

        public int DonvvTypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string DonvvTypeName { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
