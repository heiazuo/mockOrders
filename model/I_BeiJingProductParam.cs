namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_BeiJingProductParam
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string TPPV_PK { get; set; }

        [StringLength(255)]
        public string I_ProductId { get; set; }

        [StringLength(255)]
        public string TLSP_PK { get; set; }

        [StringLength(255)]
        public string I_ParamName { get; set; }

        [Column(TypeName = "text")]
        public string I_ParamValue { get; set; }
    }
}
