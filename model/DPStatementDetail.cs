namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DPStatementDetail")]
    public partial class DPStatementDetail
    {
        public int Id { get; set; }

        public int DPStatementId { get; set; }

        public int OrderId { get; set; }
    }
}
