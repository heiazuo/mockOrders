namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrintTempletDic")]
    public partial class PrintTempletDic
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [StringLength(50)]
        public string Tag { get; set; }

        [Required]
        [StringLength(100)]
        public string Vuale { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Pcode { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
