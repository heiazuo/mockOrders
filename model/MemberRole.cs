namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberRole")]
    public partial class MemberRole
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public int RoleId { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
