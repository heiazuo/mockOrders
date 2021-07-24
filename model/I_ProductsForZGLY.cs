namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_ProductsForZGLY
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string IProductName { get; set; }

        [StringLength(500)]
        public string ISku { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
