namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_EGoods
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int ProjectId { get; set; }

        public int GoodsId { get; set; }

        [StringLength(50)]
        public string CertNo { get; set; }

        public DateTime? CertDate { get; set; }

        [StringLength(500)]
        public string Url { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
