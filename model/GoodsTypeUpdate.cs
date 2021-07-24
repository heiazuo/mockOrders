namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsTypeUpdate")]
    public partial class GoodsTypeUpdate
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string TypeName { get; set; }

        [StringLength(200)]
        public string TypeCode { get; set; }

        public int? Level { get; set; }
    }
}
