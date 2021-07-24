namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransferPickingLog")]
    public partial class TransferPickingLog
    {
        public int Id { get; set; }

        public int TransferId { get; set; }

        public int TransferDetailId { get; set; }

        public int GoodsId { get; set; }

        public int StoreId { get; set; }

        [Required]
        [StringLength(100)]
        public string StoreZone { get; set; }

        public int PickingUserId { get; set; }

        public int Num { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
