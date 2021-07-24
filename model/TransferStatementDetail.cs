namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransferStatementDetail")]
    public partial class TransferStatementDetail
    {
        public int Id { get; set; }

        public int TransferStatementId { get; set; }

        public int TransferId { get; set; }
    }
}
