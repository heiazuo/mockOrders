namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Branch_CSS
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int CssId { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
