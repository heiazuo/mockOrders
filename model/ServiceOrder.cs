namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceOrder")]
    public partial class ServiceOrder
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        public int Type { get; set; }

        public int? RelationId { get; set; }

        public int CustomerId { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerPhone { get; set; }

        public int Province { get; set; }

        [Required]
        [StringLength(200)]
        public string ProvinceName { get; set; }

        public int City { get; set; }

        [Required]
        [StringLength(200)]
        public string CityName { get; set; }

        public int Country { get; set; }

        [Required]
        [StringLength(200)]
        public string CountryName { get; set; }

        [Required]
        [StringLength(500)]
        public string Address { get; set; }

        public DateTime PlantTime { get; set; }

        public int Status { get; set; }

        public int FlowState { get; set; }

        public DateTime CreationTime { get; set; }

        public int CreatorUserId { get; set; }

        public DateTime? LastModificationTime { get; set; }

        public int? LastModifierUserId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletionTime { get; set; }

        public int? DeleterUserId { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }

        public int Tenant { get; set; }

        public int ApplyUserId { get; set; }

        [Required]
        [StringLength(200)]
        public string ApplyUserName { get; set; }

        [Column(TypeName = "money")]
        public decimal SumMoney { get; set; }

        public DateTime? LastPrintTime { get; set; }
    }
}
