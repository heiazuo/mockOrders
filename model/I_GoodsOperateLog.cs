namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_GoodsOperateLog
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int ProjectId { get; set; }

        public int GoodsId { get; set; }

        public int OperateType { get; set; }

        public bool IsDel { get; set; }

        public DateTime dtCreate { get; set; }

        public DateTime dtUpdate { get; set; }
    }
}
