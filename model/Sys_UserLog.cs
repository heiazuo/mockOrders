namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_UserLog
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int DeptId { get; set; }

        [StringLength(50)]
        public string DeptName { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        public int Operate { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }

        public string Tracking { get; set; }

        [StringLength(500)]
        public string IpAddress { get; set; }
    }
}
