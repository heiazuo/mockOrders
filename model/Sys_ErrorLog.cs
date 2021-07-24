namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_ErrorLog
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string TableName { get; set; }

        [StringLength(100)]
        public string RelationId { get; set; }

        [Column(TypeName = "text")]
        public string ErrorMessage { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
