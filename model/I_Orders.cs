namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_Orders
    {
        public int Id { get; set; }

        public int I_ProjectId { get; set; }

        [Required]
        [StringLength(100)]
        public string I_OrderId { get; set; }

        [StringLength(50)]
        public string I_Customer { get; set; }

        [Column(TypeName = "money")]
        public decimal SumMoney { get; set; }

        public DateTime OrderTime { get; set; }
    }
}
