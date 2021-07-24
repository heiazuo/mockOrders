namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOStatementDetail")]
    public partial class DOStatementDetail
    {
        public int Id { get; set; }

        public int StatementId { get; set; }

        public int OrderId { get; set; }
    }
}
