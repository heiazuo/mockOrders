namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchSiteFooter
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(4000)]
        public string Url { get; set; }

        [Required]
        [StringLength(200)]
        public string Image { get; set; }

        public int Order { get; set; }

        public DateTime CreationTime { get; set; }

        public int CreatorUserId { get; set; }

        public DateTime? LastModificationTime { get; set; }

        public int? LastModifierUserId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletionTime { get; set; }

        public int? DeleterUserId { get; set; }

        [StringLength(2000)]
        public string Remark { get; set; }

        public int Tenant { get; set; }
    }
}
