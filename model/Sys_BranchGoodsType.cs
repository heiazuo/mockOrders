namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchGoodsType
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int TypeId { get; set; }

        public bool IsFloor { get; set; }

        public int Sort { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
