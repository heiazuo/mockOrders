namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsCategory")]
    public partial class GoodsCategory
    {
        public int Id { get; set; }

        public int ParentId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int? GoodsType { get; set; }

        [StringLength(200)]
        public string Url { get; set; }

        [StringLength(200)]
        public string Icon { get; set; }

        public int Order { get; set; }

        public int Tenant { get; set; }

        public DateTime CreationTime { get; set; }

        public int CreatorUserId { get; set; }

        public DateTime? LastModificationTime { get; set; }

        public int? LastModifierUserId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletionTime { get; set; }

        public int? DeleterUserId { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }
    }
}
