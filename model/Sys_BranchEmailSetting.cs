namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchEmailSetting
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(50)]
        public string SMTPServer { get; set; }

        public bool IsEnableSSL { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(100)]
        public string NickName { get; set; }

        public bool IsCheck { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
