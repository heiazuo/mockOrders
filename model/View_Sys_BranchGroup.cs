namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Sys_BranchGroup
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AgentId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string ShortName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Province { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProvinceSort { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string City { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CitySort { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string CityAlias { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        [StringLength(50)]
        public string LinkMan { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsUseSiteGoods { get; set; }

        [Column(TypeName = "text")]
        public string Introduction { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime AddTime { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsEnable { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserNum { get; set; }

        [Key]
        [Column(Order = 14)]
        public DateTime ExpiredDate { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(200)]
        public string Domain { get; set; }

        [StringLength(200)]
        public string Domain2 { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(200)]
        public string DonvvDomain { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool IsEasy { get; set; }

        public int? GroupId { get; set; }

        [StringLength(50)]
        public string JoinType { get; set; }

        public bool? IsGroupAccount { get; set; }

        [StringLength(200)]
        public string GroupName { get; set; }

        public int? LeaderBranchId { get; set; }

        public int? GroupUserNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime? GroupExpiredDate { get; set; }

        public string Memo { get; set; }
    }
}
