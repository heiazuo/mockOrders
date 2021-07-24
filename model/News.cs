namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class News
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(300)]
        public string Title { get; set; }

        public int NewsTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }

        public DateTime PublishDate { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Content { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool IsTop { get; set; }

        public bool IsEnable { get; set; }
    }
}
