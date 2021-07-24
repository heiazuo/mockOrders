namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchFloorBrandingWall
    {
        public int Id { get; set; }

        public int BranchFloorId { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public int ColumnsNum { get; set; }

        public int ColumnsSpace { get; set; }

        public bool IsEnable { get; set; }

        public DateTime UpdateTime { get; set; }

        public DateTime AddTime { get; set; }

        public int BranchId { get; set; }
    }
}
