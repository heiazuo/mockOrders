namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThirdPartyOrder")]
    public partial class ThirdPartyOrder
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [StringLength(200)]
        public string ThirdPartyOrderId { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(200)]
        public string ReceiverName { get; set; }

        [StringLength(200)]
        public string ReceiverCompany { get; set; }

        [StringLength(50)]
        public string ReceiverMobile { get; set; }

        [StringLength(500)]
        public string ReceiverAddress { get; set; }

        [StringLength(20)]
        public string ReceiverZip { get; set; }

        [StringLength(200)]
        public string CreatorName { get; set; }

        [StringLength(50)]
        public string CreatorMobile { get; set; }

        [StringLength(200)]
        public string CreatorOrgName { get; set; }

        public int? State { get; set; }

        public bool IsDelete { get; set; }

        public DateTime? AddAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        public int ProjectId { get; set; }
    }
}
