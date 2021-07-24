namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YangCaiOrderLog")]
    public partial class YangCaiOrderLog
    {
        public int Id { get; set; }

        public int? OrderId { get; set; }

        [StringLength(100)]
        public string UserCode { get; set; }

        [StringLength(4000)]
        public string LogText { get; set; }

        public DateTime? UpdateTime { get; set; }

        [Required]
        [StringLength(100)]
        public string ReceiptCode { get; set; }

        public decimal ReceiptAmount { get; set; }
    }
}
