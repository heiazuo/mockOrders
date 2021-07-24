namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_CarLog
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public decimal Kil { get; set; }

        public decimal Oil { get; set; }

        [Column(TypeName = "money")]
        public decimal OilMoney { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
