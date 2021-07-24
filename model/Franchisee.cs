namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Franchisee")]
    public partial class Franchisee
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(200)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(100)]
        public string CompanyProvince { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyCity { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyArea { get; set; }

        [Required]
        [StringLength(200)]
        public string CompanyAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string ContractWay { get; set; }

        [Required]
        [StringLength(100)]
        public string LocationProvince { get; set; }

        [Required]
        [StringLength(50)]
        public string LocationCity { get; set; }

        [Required]
        [StringLength(50)]
        public string LocationArea { get; set; }

        [Required]
        [StringLength(200)]
        public string LocationAddress { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string PassWord { get; set; }

        public int RoleId { get; set; }

        [Required]
        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string QQ { get; set; }
    }
}
