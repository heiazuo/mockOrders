namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EquipmentLog")]
    public partial class EquipmentLog
    {
        public int Id { get; set; }

        public int GoodsId { get; set; }

        [Required]
        [StringLength(500)]
        public string DeviceNum { get; set; }

        [StringLength(50)]
        public string RelationId { get; set; }

        public int? OperationType { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
