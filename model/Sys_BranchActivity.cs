namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchActivity
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Content { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        [Required]
        [StringLength(200)]
        public string PhotoPath { get; set; }

        [Required]
        [StringLength(500)]
        public string Link { get; set; }

        public bool IsEnable { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }

        public int? ProductTpn { get; set; }
    }
}
