namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchServicePromise
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int Sort { get; set; }

        public int Cols { get; set; }

        public int Col_Width { get; set; }

        public int Rows { get; set; }

        public int Row_Height { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
