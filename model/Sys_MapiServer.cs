namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_MapiServer
    {
        public int Id { get; set; }

        public int ServerId { get; set; }

        [Required]
        [StringLength(200)]
        public string ServerName { get; set; }

        [Required]
        [StringLength(500)]
        public string ServerUrl { get; set; }

        [Required]
        [StringLength(500)]
        public string AppKey { get; set; }

        [Required]
        [StringLength(500)]
        public string AppSecret { get; set; }

        [StringLength(500)]
        public string Token { get; set; }

        public DateTime? ExpiresTime { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
