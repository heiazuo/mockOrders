namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchArea
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int? AreaIndex { get; set; }

        public int TypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string AreaName { get; set; }

        [Required]
        [StringLength(50)]
        public string LeftLayout { get; set; }

        [Required]
        [StringLength(500)]
        public string Image1 { get; set; }

        [Required]
        [StringLength(500)]
        public string Image2 { get; set; }

        [Required]
        [StringLength(500)]
        public string Image3 { get; set; }

        [Required]
        [StringLength(500)]
        public string Href1 { get; set; }

        [Required]
        [StringLength(500)]
        public string Href2 { get; set; }

        [Required]
        [StringLength(500)]
        public string Href3 { get; set; }

        public DateTime? UpdateTime { get; set; }

        [StringLength(500)]
        public string Image4 { get; set; }

        [StringLength(500)]
        public string Image5 { get; set; }

        [StringLength(500)]
        public string Image6 { get; set; }

        [StringLength(500)]
        public string Image7 { get; set; }

        [StringLength(500)]
        public string Image8 { get; set; }

        [StringLength(50)]
        public string Href4 { get; set; }

        [StringLength(50)]
        public string Href5 { get; set; }

        [StringLength(50)]
        public string Href6 { get; set; }

        [StringLength(50)]
        public string Href7 { get; set; }

        [StringLength(50)]
        public string Href8 { get; set; }

        [StringLength(50)]
        public string BackGroundColor { get; set; }
    }
}
