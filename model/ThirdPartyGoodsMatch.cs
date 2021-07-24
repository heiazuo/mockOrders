namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThirdPartyGoodsMatch")]
    public partial class ThirdPartyGoodsMatch
    {
        public int Id { get; set; }

        public int BranchID { get; set; }

        [Required]
        [StringLength(64)]
        public string ThirdPartyGoodsId { get; set; }

        [StringLength(500)]
        public string ThirdPartyGoodsName { get; set; }

        public int LocalGoodsId { get; set; }

        [StringLength(500)]
        public string LocalGoodsName { get; set; }
    }
}
