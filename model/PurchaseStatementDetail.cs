namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseStatementDetail")]
    public partial class PurchaseStatementDetail
    {
        public int Id { get; set; }

        public int PurchaseStatementId { get; set; }

        public int PurchaseId { get; set; }
    }
}
