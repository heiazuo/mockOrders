namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Notify_Setting
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string AppKey { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(200)]
        public string EmailName { get; set; }

        [StringLength(200)]
        public string EmailPsw { get; set; }

        [StringLength(200)]
        public string EmailSmtp { get; set; }

        [StringLength(200)]
        public string EmailNickName { get; set; }

        public bool IsEnabled { get; set; }

        public int Type { get; set; }

        [StringLength(200)]
        public string Extend1 { get; set; }

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
    }
}
