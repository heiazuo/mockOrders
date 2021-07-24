namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThirdPartyCategory")]
    public partial class ThirdPartyCategory
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public long ThirdPartyCategoryId { get; set; }

        [Required]
        [StringLength(64)]
        public string ThirdPartyCategoryName { get; set; }

        public int ProjectId { get; set; }
    }
}
