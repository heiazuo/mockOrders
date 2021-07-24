namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Agent
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public int ParentId { get; set; }

        [Required]
        [StringLength(50)]
        public string Province { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        public int CityId { get; set; }

        [StringLength(200)]
        public string Bank { get; set; }

        [StringLength(100)]
        public string AcountNo { get; set; }

        [StringLength(50)]
        public string LinkMan { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
