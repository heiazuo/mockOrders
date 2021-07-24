namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Agent_Users
    {
        public int Id { get; set; }

        public int AgentId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string LoginName { get; set; }

        [Required]
        [StringLength(200)]
        public string PassWord { get; set; }

        [Required]
        [StringLength(50)]
        public string Telphone { get; set; }

        public bool IsAdmin { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
