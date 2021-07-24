namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Branch
    {
        public int Id { get; set; }

        public int AgentId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string ShortName { get; set; }

        [Required]
        [StringLength(50)]
        public string Province { get; set; }

        public int ProvinceSort { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        public int CityId { get; set; }

        public int CitySort { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        [StringLength(50)]
        public string LinkMan { get; set; }

        public int IsUseSiteGoods { get; set; }

        [Column(TypeName = "text")]
        public string Introduction { get; set; }

        public DateTime AddTime { get; set; }

        public int IsEnable { get; set; }

        public int UserNum { get; set; }

        public DateTime ExpiredDate { get; set; }

        [Required]
        [StringLength(200)]
        public string Domain { get; set; }

        [Required]
        [StringLength(200)]
        public string DonvvDomain { get; set; }

        [Required]
        [StringLength(50)]
        public string BranchType { get; set; }

        [StringLength(200)]
        public string Domain2 { get; set; }

        public bool IsEasy { get; set; }

        [Required]
        [StringLength(50)]
        public string CityAlias { get; set; }

        public string Memo { get; set; }
    }
}
