namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CrawlerRequest")]
    public partial class CrawlerRequest
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(500)]
        public string Url { get; set; }

        public int DataSource { get; set; }

        public int CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        public bool IsGrabGroup { get; set; }

        public int SuccessNum { get; set; }

        public int FailNum { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }

        public int CreateBy { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        [StringLength(50)]
        public string CreateByName { get; set; }
    }
}
