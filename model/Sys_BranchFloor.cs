namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchFloor
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int FloorIndex { get; set; }

        public int TypeId { get; set; }

        [Required]
        [StringLength(10)]
        public string FloorName { get; set; }

        [Required]
        [StringLength(50)]
        public string LeftLayout { get; set; }

        public bool AutoSub { get; set; }

        [Required]
        [StringLength(500)]
        public string Image1 { get; set; }

        [Required]
        [StringLength(500)]
        public string Href1 { get; set; }

        [Required]
        [StringLength(500)]
        public string Image2 { get; set; }

        [Required]
        [StringLength(500)]
        public string Href2 { get; set; }

        [Required]
        [StringLength(500)]
        public string Image3 { get; set; }

        [Required]
        [StringLength(500)]
        public string Href3 { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string BackGroundColor { get; set; }

        public bool IsDisplayCustomerTypeAndGoods { get; set; }

        public bool IsShow { get; set; }
    }
}
