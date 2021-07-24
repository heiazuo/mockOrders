namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_BeiJingGoodsMap
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string I_BeiJingProductId { get; set; }

        public int DonvvGoodsId { get; set; }

        public DateTime UpdateTime { get; set; }

        public int BranchId { get; set; }
    }
}
