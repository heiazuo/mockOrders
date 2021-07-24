namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchFloorDisplayType
    {
        public int Id { get; set; }

        public int BranchFloorId { get; set; }

        public int DisplayTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string DisplayTypeName { get; set; }

        public int GoodsId { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(200)]
        public string GoodsName { get; set; }

        public int TypeSort { get; set; }

        public int GoodsSort { get; set; }
    }
}
