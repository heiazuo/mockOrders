namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Strategy_GrossProfit
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int Term { get; set; }

        public int Way { get; set; }

        public bool IsEnabled { get; set; }

        public int? Extend1 { get; set; }

        [StringLength(200)]
        public string Extend2 { get; set; }

        public DateTime CreationTime { get; set; }

        public int CreatorUserId { get; set; }

        public DateTime? LastModificationTime { get; set; }

        public int? LastModifierUserId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletionTime { get; set; }

        public int? DeleterUserId { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        public int Tenant { get; set; }

        public int Privilege { get; set; }
    }
}
