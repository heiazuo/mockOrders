namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SupplierLog")]
    public partial class SupplierLog
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int SupplierId { get; set; }

        [StringLength(200)]
        public string SupplierName { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string OperationType { get; set; }

        [Required]
        [StringLength(200)]
        public string Operation { get; set; }

        public DateTime AddTime { get; set; }

        [Required]
        [StringLength(500)]
        public string Tracking { get; set; }
    }
}
