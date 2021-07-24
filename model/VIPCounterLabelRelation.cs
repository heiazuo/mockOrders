namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VIPCounterLabelRelation")]
    public partial class VIPCounterLabelRelation
    {
        public int Id { get; set; }

        public int LableId { get; set; }

        public int Type { get; set; }

        public int Value { get; set; }

        public int CounterId { get; set; }

        public int BranchId { get; set; }

        public DateTime CreateAt { get; set; }
    }
}
