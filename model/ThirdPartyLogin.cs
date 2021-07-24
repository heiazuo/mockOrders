namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThirdPartyLogin")]
    public partial class ThirdPartyLogin
    {
        public int Id { get; set; }

        public int? MemberId { get; set; }

        [StringLength(100)]
        public string UUId { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public int? BranchId { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
