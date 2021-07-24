namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VIPCounterDetail")]
    public partial class VIPCounterDetail
    {
        public int Id { get; set; }

        public int CounterId { get; set; }

        public int GoodsId { get; set; }

        [Column(TypeName = "money")]
        public decimal VIPPrice { get; set; }

        public int Level { get; set; }

        public bool IsSales { get; set; }

        public DateTime AddTime { get; set; }
    }
}
