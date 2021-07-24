namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_ProductsMapForZGLY
    {
        public int Id { get; set; }

        [StringLength(500)]
        public string IProductSku { get; set; }

        public int? DonvvSku { get; set; }

        public DateTime? UpdateTime { get; set; }

        public int? BranchId { get; set; }
    }
}
