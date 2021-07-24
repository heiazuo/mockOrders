namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DistributionOperation")]
    public partial class DistributionOperation
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int OrderId { get; set; }

        public bool IsPicked { get; set; }

        public bool IsPrinted { get; set; }

        public bool IsDelivered { get; set; }

        public bool IsArrived { get; set; }

        public bool IsDelete { get; set; }
    }
}
