namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderStatementCrossInvoice")]
    public partial class OrderStatementCrossInvoice
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int StatementId { get; set; }

        public int InvoiceRequireId { get; set; }

        public bool IsDetele { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
