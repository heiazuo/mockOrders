namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Notify_Templet
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Mode { get; set; }

        public int Type { get; set; }

        public int? SignId { get; set; }

        public long? Code { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Templet { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string DisplayTemplet { get; set; }

        public int Status { get; set; }

        [StringLength(200)]
        public string Reason { get; set; }

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
    }
}
