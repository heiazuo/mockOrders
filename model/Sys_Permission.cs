namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Permission
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ClientType { get; set; }

        public int GroupId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public bool IsMenu { get; set; }

        [Required]
        [StringLength(50)]
        public string Menu { get; set; }

        [Required]
        [StringLength(50)]
        public string Controller { get; set; }

        [Required]
        [StringLength(50)]
        public string Action { get; set; }

        [Required]
        [StringLength(50)]
        public string Icon { get; set; }

        public int Sort { get; set; }

        public bool IsBlank { get; set; }

        [Required]
        [StringLength(200)]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
