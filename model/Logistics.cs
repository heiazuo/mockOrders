namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Logistics
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }

        public int OrderId { get; set; }

        [Required]
        [StringLength(100)]
        public string LogisticName { get; set; }

        [StringLength(100)]
        public string LogisticNo { get; set; }

        public DateTime? AddAt { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
