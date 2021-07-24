namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GoodsParamValue")]
    public partial class GoodsParamValue
    {
        public int Id { get; set; }

        public int GoodsId { get; set; }

        public int ParamId { get; set; }

        [Required]
        [StringLength(500)]
        public string Value { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(50)]
        public string GroupName { get; set; }
    }
}
