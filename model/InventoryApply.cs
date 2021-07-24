namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryApply")]
    public partial class InventoryApply
    {
        public int Id { get; set; }

        public int StoreId { get; set; }

        [Required]
        [StringLength(100)]
        public string StoreZone { get; set; }

        public int GoodsId { get; set; }

        public int Num { get; set; }

        public DateTime CreateAt { get; set; }

        public int CreateBy { get; set; }

        [StringLength(100)]
        public string Remarks { get; set; }

        public int State { get; set; }

        public DateTime? AuditAt { get; set; }

        public int? AuditBy { get; set; }

        public int? OldNum { get; set; }
    }
}
