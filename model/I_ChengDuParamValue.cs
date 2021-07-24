namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_ChengDuParamValue
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int GoodsId { get; set; }

        public int ParamId { get; set; }

        [Required]
        [StringLength(500)]
        public string Value { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
