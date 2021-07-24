namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmailSetting")]
    public partial class EmailSetting
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(64)]
        public string SmtpServer { get; set; }

        public int Port { get; set; }

        [Required]
        [StringLength(32)]
        public string Email { get; set; }

        [Required]
        [StringLength(32)]
        public string Password { get; set; }

        [Required]
        [StringLength(64)]
        public string Nickname { get; set; }
    }
}
