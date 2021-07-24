namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KuaiPuOrder")]
    public partial class KuaiPuOrder
    {
        public int Id { get; set; }

        public int? BranchId { get; set; }

        public int? OrderId { get; set; }

        public DateTime? OrderTime { get; set; }

        [StringLength(50)]
        public string ThirdPartyId { get; set; }

        public int? ProjectId { get; set; }

        public bool? IsSync { get; set; }

        [StringLength(50)]
        public string DeliverStatus { get; set; }

        [StringLength(50)]
        public string Customer { get; set; }

        public DateTime? AddTime { get; set; }

        public string Memo { get; set; }
    }
}
