namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsTypeParamOption")]
    public partial class GoodsTypeParamOption
    {
        public int Id { get; set; }

        public int ParamId { get; set; }

        [Required]
        [StringLength(200)]
        public string Value { get; set; }

        public int Sort { get; set; }
    }
}
