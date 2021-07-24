namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AttachedFil")]
    public partial class AttachedFil
    {
        public int Id { get; set; }

        public int RelationNum { get; set; }

        public int MemberId { get; set; }

        [Required]
        [StringLength(100)]
        public string FileUrl { get; set; }

        public int Type { get; set; }

        public DateTime AddAt { get; set; }
    }
}
