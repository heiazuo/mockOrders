namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsTypeParam")]
    public partial class GoodsTypeParam
    {
        public int Id { get; set; }

        public int GroupId { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public int Sort { get; set; }

        public bool HasOption { get; set; }

        public bool IsCondition { get; set; }

        public int BranchId { get; set; }
    }
}
