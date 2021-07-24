namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_User_Role
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string RoleName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string GroupName { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string LoginName { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(200)]
        public string PassWord { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptId { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool IsAdmin { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool IsValid { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool IsSales { get; set; }
    }
}
