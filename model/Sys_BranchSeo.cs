namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchSeo
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Keywords { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [StringLength(2000)]
        public string Code { get; set; }

        public int Tenant { get; set; }
    }
}
