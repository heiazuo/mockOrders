namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_ChengDuActivityGoods
    {
        public int Id { get; set; }

        public int ActivityId { get; set; }

        public int GoodsId { get; set; }

        public int VastCount { get; set; }

        [Column(TypeName = "money")]
        public decimal VastPrice { get; set; }
    }
}
