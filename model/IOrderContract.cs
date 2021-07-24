namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IOrderContract")]
    public partial class IOrderContract
    {
        public int Id { get; set; }

        public int? OrderId { get; set; }

        public int? ContractId { get; set; }

        [StringLength(500)]
        public string ContractNum { get; set; }

        public DateTime? DeliveryTime { get; set; }

        [StringLength(50)]
        public string ReceiveUser { get; set; }

        public int? BranchId { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }
    }
}
