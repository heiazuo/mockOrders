namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MajorParamsDetail")]
    public partial class MajorParamsDetail
    {
        public int Id { get; set; }

        public int GoodsId { get; set; }

        public int BranchId { get; set; }

        public int PlatId { get; set; }

        [Required]
        [StringLength(100)]
        public string ParamsName { get; set; }

        [StringLength(100)]
        public string ParamsValue { get; set; }

        public int UserBy { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
