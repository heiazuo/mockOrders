namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupOrderStatementDetail")]
    public partial class GroupOrderStatementDetail
    {
        public int Id { get; set; }

        public int OrderStatementId { get; set; }

        public int OrderId { get; set; }
    }
}
