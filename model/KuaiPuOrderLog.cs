namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KuaiPuOrderLog")]
    public partial class KuaiPuOrderLog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string LogType { get; set; }

        public int BranchId { get; set; }

        public int OrderId { get; set; }

        public string RequestContent { get; set; }

        [Required]
        public string LogContent { get; set; }

        public DateTime AddTime { get; set; }
    }
}
