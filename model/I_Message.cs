namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_Message
    {
        public int Id { get; set; }

        public int IProjectId { get; set; }

        public int BranchId { get; set; }

        public int? Type { get; set; }

        [Column(TypeName = "text")]
        public string Result { get; set; }

        public bool? IsDelete { get; set; }

        public DateTime? UpdateAt { get; set; }

        [Column(TypeName = "text")]
        public string Remark { get; set; }
    }
}
