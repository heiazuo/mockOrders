namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VirtualInventory")]
    public partial class VirtualInventory
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int GoodsId { get; set; }

        public int Num { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
