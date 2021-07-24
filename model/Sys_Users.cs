namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Users
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string LoginName { get; set; }

        [Required]
        [StringLength(200)]
        public string PassWord { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int BranchId { get; set; }

        public int DeptId { get; set; }

        public bool IsSales { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        public DateTime? BirthDay { get; set; }

        public bool IsYinLi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? JoinDate { get; set; }

        [StringLength(18)]
        public string IDCard { get; set; }

        public DateTime ModifyTime { get; set; }

        public bool IsCheckMobile { get; set; }

        public bool IsValid { get; set; }

        public bool IsAdmin { get; set; }

        [StringLength(200)]
        public string token { get; set; }

        public DateTime? tokenEndDate { get; set; }

        [StringLength(50)]
        public string DingId { get; set; }

        public DateTime? dtLockTime { get; set; }

        public int? intLockNum { get; set; }

        public DateTime? LastModifyPwdAt { get; set; }
    }
}
