namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberCart")]
    public partial class MemberCart
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public int GoodsId { get; set; }

        public int Num { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool IsEnable { get; set; }

        public bool IsChecked { get; set; }

        public int Multiples { get; set; }

        public int DisplayNum { get; set; }

        [Required]
        [StringLength(50)]
        public string DisplayUnit { get; set; }
    }
}
