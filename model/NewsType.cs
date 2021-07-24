namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewsType")]
    public partial class NewsType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string TypeName { get; set; }

        public DateTime CreateDate { get; set; }

        public int BranchId { get; set; }
    }
}
