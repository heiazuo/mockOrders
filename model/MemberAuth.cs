namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberAuth")]
    public partial class MemberAuth
    {
        public int Id { get; set; }

        public int? MemberId { get; set; }

        public int? BranchId { get; set; }

        [StringLength(200)]
        public string AccessToken { get; set; }

        [StringLength(200)]
        public string RereshToken { get; set; }

        public DateTime? UpdateTime { get; set; }

        [StringLength(200)]
        public string StrustNo { get; set; }

        public int? ExpireTimeSpan { get; set; }
    }
}
