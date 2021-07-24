namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Group
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public int LeaderBranchId { get; set; }

        public int UserNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpiredDate { get; set; }

        public DateTime AddTime { get; set; }

        public bool? IsDistribuionGroup { get; set; }
    }
}
