namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Sys_Distribution
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string GroupName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PBranchId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TopBranchId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Level { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime AddTime { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(100)]
        public string TopBranchName { get; set; }

        [StringLength(100)]
        public string PBranchName { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AgentId { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(100)]
        public string BranchName { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(100)]
        public string BranchShortName { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(50)]
        public string Province { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProvinceSort { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string City { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CitySort { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(50)]
        public string CityAlias { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        [StringLength(50)]
        public string LinkMan { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsUseSiteGoods { get; set; }

        [Column(TypeName = "text")]
        public string Introduction { get; set; }

        [Key]
        [Column(Order = 19)]
        public DateTime BranchAddTime { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IsEnable { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserNum { get; set; }

        [Key]
        [Column(Order = 22)]
        public DateTime ExpiredDate { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(200)]
        public string Domain { get; set; }

        [StringLength(200)]
        public string Domain2 { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(200)]
        public string DonvvDomain { get; set; }

        [Key]
        [Column(Order = 25)]
        public bool IsEasy { get; set; }

        public string Memo { get; set; }

        [Key]
        [Column(Order = 26)]
        public double ParentReceiveRate { get; set; }
    }
}
