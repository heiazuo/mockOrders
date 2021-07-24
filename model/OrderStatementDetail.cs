namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderStatementDetail")]
    public partial class OrderStatementDetail
    {
        public int Id { get; set; }

        public int OrderStatementId { get; set; }

        public int OrderId { get; set; }
    }
}
