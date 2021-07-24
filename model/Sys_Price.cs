namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Price
    {
        public int Id { get; set; }

        public int Pirce { get; set; }

        public int StartNum { get; set; }

        public int StartAmount { get; set; }

        [Required]
        [StringLength(200)]
        public string Memo { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
