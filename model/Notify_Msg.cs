namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Notify_Msg
    {
        public int Id { get; set; }

        public int TempletId { get; set; }

        [Column(TypeName = "text")]
        public string TempletValue { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Content { get; set; }

        public int? SendId { get; set; }

        public int? ReceiveId { get; set; }

        public int Status { get; set; }

        public int Type { get; set; }

        public int Item { get; set; }

        public int? RelationId { get; set; }

        [StringLength(200)]
        public string Extend1 { get; set; }

        public int? Extend2 { get; set; }

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
