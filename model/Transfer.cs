namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transfer")]
    public partial class Transfer
    {
        public int Id { get; set; }

        public int OutBranchId { get; set; }

        public int OutStoreId { get; set; }

        public int OutStoreUserId { get; set; }

        public DateTime OutStoreDate { get; set; }

        [Required]
        [StringLength(50)]
        public string OutStatus { get; set; }

        public int LogisticsInfomationId { get; set; }

        public int InBranchId { get; set; }

        public int InStoreId { get; set; }

        public int InStoreUserId { get; set; }

        public DateTime InStoreDate { get; set; }

        [Required]
        [StringLength(50)]
        public string InStatus { get; set; }

        [Required]
        [StringLength(500)]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }

        public DateTime AddTime { get; set; }

        public int RowNum { get; set; }

        [Column(TypeName = "money")]
        public decimal SumMoney { get; set; }

        public int UserId { get; set; }

        public bool IsDelete { get; set; }

        public bool IsChecked { get; set; }

        public bool IsArchive { get; set; }
    }
}
