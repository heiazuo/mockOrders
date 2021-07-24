namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberPoint")]
    public partial class MemberPoint
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public int RelationId { get; set; }

        [Column(TypeName = "money")]
        public decimal Income { get; set; }

        [Column(TypeName = "money")]
        public decimal Spend { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        [StringLength(1000)]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
