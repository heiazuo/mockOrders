namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_PrintSetting
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [StringLength(500)]
        public string Order_Header { get; set; }

        [StringLength(500)]
        public string Order_LogoUrl { get; set; }

        [StringLength(500)]
        public string Order_Instruction { get; set; }

        public DateTime UpdateTime { get; set; }

        public int? PrintFlag { get; set; }

        public bool IsDefault { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(32)]
        public string QrCode { get; set; }
    }
}
