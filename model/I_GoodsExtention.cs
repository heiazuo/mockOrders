namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_GoodsExtention
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }

        public int GoodsId { get; set; }

        [StringLength(500)]
        public string AttrGroup { get; set; }

        [StringLength(500)]
        public string AttrKey { get; set; }

        [StringLength(500)]
        public string AttrValue { get; set; }
    }
}
