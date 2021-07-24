namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VIPApplyModify")]
    public partial class VIPApplyModify
    {
        public int Id { get; set; }

        public int ApplyId { get; set; }

        public int GoodsId { get; set; }

        public int OldNum { get; set; }

        public int NewNum { get; set; }

        public int OperaterId { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Unit { get; set; }
    }
}
