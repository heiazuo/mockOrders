namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryLog")]
    public partial class InventoryLog
    {
        public int Id { get; set; }

        public int GoodsId { get; set; }

        public int StoreId { get; set; }

        [Required]
        [StringLength(50)]
        public string Operate { get; set; }

        public int RelationId { get; set; }

        public int OldNum { get; set; }

        public int Num { get; set; }

        [Column(TypeName = "money")]
        public decimal AC { get; set; }

        [Required]
        [StringLength(100)]
        public string OldStoreZone { get; set; }

        [Required]
        [StringLength(100)]
        public string StoreZone { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }

        public int NewNum { get; set; }

        public bool IsCustomGoods { get; set; }

        [Column(TypeName = "money")]
        public decimal AFC { get; set; }

        [StringLength(100)]
        public string Remark { get; set; }
    }
}
