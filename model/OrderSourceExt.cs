namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderSourceExt")]
    public partial class OrderSourceExt
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderSource { get; set; }
    }
}
