namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VipCounterLabelGoods
    {
        public int BranchId { get; set; }

        public int CounterId { get; set; }

        public int GoodsId { get; set; }

        public int LabelId { get; set; }

        public int Id { get; set; }
    }
}
