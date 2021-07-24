namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quotation")]
    public partial class Quotation
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public DateTime QuotationTime { get; set; }

        public DateTime ValidTime { get; set; }

        public int OrderId { get; set; }

        public int ValidDay { get; set; }

        public bool IsDelete { get; set; }

        public int BranchId { get; set; }

        public byte DiscountRate { get; set; }
    }
}
