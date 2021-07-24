namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CatagoryParams
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string ITypeCode { get; set; }

        public int BranchId { get; set; }

        public int PlatId { get; set; }

        [Required]
        [StringLength(100)]
        public string ParamsName { get; set; }

        public int UserBy { get; set; }

        public DateTime UpdateAt { get; set; }
    }
}
