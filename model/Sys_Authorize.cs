namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Authorize
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public DateTime OldExpiredDate { get; set; }

        public int AuthorizeYear { get; set; }

        public DateTime NewExpiredDate { get; set; }

        public int OldUserNum { get; set; }

        public int AuthorizeNum { get; set; }

        public int NewUserNum { get; set; }

        [Column(TypeName = "money")]
        public decimal Money { get; set; }

        [Required]
        [StringLength(50)]
        public string PayStatus { get; set; }

        public int SysUserId { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
