namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberFav")]
    public partial class MemberFav
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public int GoodsId { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
