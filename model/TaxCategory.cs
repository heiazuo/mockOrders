namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaxCategory")]
    public partial class TaxCategory
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Column(TypeName = "money")]
        public decimal TaxRate { get; set; }

        [StringLength(1000)]
        public string GoodsCategory { get; set; }

        [StringLength(2000)]
        public string DescribeInfo { get; set; }

        [StringLength(2000)]
        public string Memo { get; set; }

        public bool IsDefault { get; set; }

        public int AddUserId { get; set; }

        public DateTime AddTime { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateTime { get; set; }

        [StringLength(500)]
        public string CategoryShortName { get; set; }

        [StringLength(500)]
        public string TaxCode { get; set; }

        public int? GoodsTypeId { get; set; }
    }
}
