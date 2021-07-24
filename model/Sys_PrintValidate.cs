namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_PrintValidate
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        [StringLength(500)]
        public string Token { get; set; }

        public DateTime? ExpiresTime { get; set; }

        public DateTime AddTime { get; set; }
    }
}
