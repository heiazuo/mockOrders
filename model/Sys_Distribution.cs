namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Distribution
    {
        public int Id { get; set; }

        public int GroupId { get; set; }

        public int BranchId { get; set; }

        public int PBranchId { get; set; }

        public int TopBranchId { get; set; }

        public int Level { get; set; }

        public DateTime AddTime { get; set; }

        public double ParentReceiveRate { get; set; }
    }
}
