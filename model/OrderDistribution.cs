namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDistribution")]
    public partial class OrderDistribution
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int BranchId { get; set; }

        public int PBranchId { get; set; }

        public int OriginalBranchId { get; set; }

        public double ParentReceiveRate { get; set; }

        [Column(TypeName = "money")]
        public decimal SumMoney { get; set; }

        public int UserId { get; set; }

        public DateTime AddTime { get; set; }

        public bool IsDelete { get; set; }

        public int PayStatus { get; set; }

        [Column(TypeName = "money")]
        public decimal PayChargeOff { get; set; }

        public int InvoiceStatus { get; set; }

        [Column(TypeName = "money")]
        public decimal InvoiceChargeOff { get; set; }
    }
}
