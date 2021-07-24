namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_PermissionGroup
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ClientType { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int Sort { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
