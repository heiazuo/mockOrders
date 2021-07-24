namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_ChengduActivity
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int IProjectId { get; set; }

        public bool IsEnable { get; set; }

        [Required]
        [StringLength(1000)]
        public string Name { get; set; }
    }
}
