namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Sms
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [StringLength(250)]
        public string Mobile { get; set; }

        public int SMSCode { get; set; }

        [StringLength(500)]
        public string Content { get; set; }

        public int? Status { get; set; }

        public DateTime? UpdateTime { get; set; }

        public int UserId { get; set; }
    }
}
