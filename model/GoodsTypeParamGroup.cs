namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsTypeParamGroup")]
    public partial class GoodsTypeParamGroup
    {
        public int Id { get; set; }

        public int TypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string ParamSource { get; set; }

        [Required]
        [StringLength(50)]
        public string GroupName { get; set; }

        public int Sort { get; set; }

        public DateTime UpdateTime { get; set; }

        public int BranchId { get; set; }
    }
}
