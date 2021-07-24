namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_User_Permission
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PermissionId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ClientType { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupId { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool IsMenu { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string Menu { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string Controller { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string Action { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string Icon { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Sort { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool IsBlank { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(200)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string GroupName { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupSort { get; set; }
    }
}
