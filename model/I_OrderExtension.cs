namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_OrderExtension
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }

        public int OrderId { get; set; }

        [StringLength(500)]
        public string AttrName { get; set; }

        [StringLength(500)]
        public string AttrVal { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
