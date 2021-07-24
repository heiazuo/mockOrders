namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeliveryLineMember")]
    public partial class DeliveryLineMember
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public int LineId { get; set; }

        public int Distance { get; set; }

        [StringLength(100)]
        public string Remark { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
