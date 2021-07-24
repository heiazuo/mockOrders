namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThirdPartyGoodsCategoryMatch")]
    public partial class ThirdPartyGoodsCategoryMatch
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public long ThirdPartyGoodsCategoryId { get; set; }

        [StringLength(500)]
        public string ThirdPartyGoodsCategoryName { get; set; }

        public int LocalGoodsCategoryId { get; set; }

        [StringLength(500)]
        public string LocalGoodsCategoryName { get; set; }
    }
}
