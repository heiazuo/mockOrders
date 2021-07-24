namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InventoryStock")]
    public partial class InventoryStock
    {
        public int Id { get; set; }

        public int StoreId { get; set; }

        public int GoodsId { get; set; }

        public int MinStock { get; set; }

        public int MaxStock { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }

        public int UserId { get; set; }
    }
}
