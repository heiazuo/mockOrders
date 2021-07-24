namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_ChengDuCategoryParam
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Code { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [Column(TypeName = "text")]
        public string Vals { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
