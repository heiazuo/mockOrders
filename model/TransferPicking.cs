namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransferPicking")]
    public partial class TransferPicking
    {
        public int Id { get; set; }

        public int TransferId { get; set; }

        public int PickingUserId { get; set; }

        public int DistributeUserId { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
