namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NeedToPurchaseOrder")]
    public partial class NeedToPurchaseOrder
    {
        public int Id { get; set; }

        public int NeedToPurchaseId { get; set; }

        public int OrderId { get; set; }
    }
}
