namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MallSideBar")]
    public partial class MallSideBar
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int UserId { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(10)]
        public string HoverName { get; set; }

        [Required]
        [StringLength(50)]
        public string Icon { get; set; }

        public bool IsEnable { get; set; }
    }
}
