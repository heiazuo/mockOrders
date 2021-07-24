namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleReportFakeData")]
    public partial class SaleReportFakeData
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public DateTime Date { get; set; }

        public int Count { get; set; }

        [Column(TypeName = "money")]
        public decimal OrderAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Column(TypeName = "money")]
        public decimal GrossProfit { get; set; }
    }
}
