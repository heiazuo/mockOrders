namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PayLog")]
    public partial class PayLog
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public string LogText { get; set; }

        [StringLength(50)]
        public string Amount { get; set; }

        public DateTime? AddTime { get; set; }
    }
}
