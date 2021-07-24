namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Sys_Users
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string LoginName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string PassWord { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptId { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        public DateTime? BirthDay { get; set; }

        [Column(TypeName = "date")]
        public DateTime? JoinDate { get; set; }

        [StringLength(18)]
        public string IDCard { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime ModifyTime { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        [StringLength(200)]
        public string token { get; set; }

        public DateTime? tokenEndDate { get; set; }

        [StringLength(50)]
        public string DingId { get; set; }

        [StringLength(100)]
        public string BranchName { get; set; }

        [StringLength(50)]
        public string DeptName { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool IsValid { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool IsSales { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool IsAdmin { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool IsYinLi { get; set; }
    }
}
