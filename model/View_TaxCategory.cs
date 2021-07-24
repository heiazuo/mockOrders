namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_TaxCategory
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal TaxRate { get; set; }

        [StringLength(500)]
        public string TaxCode { get; set; }

        [StringLength(1000)]
        public string GoodsCategory { get; set; }

        [StringLength(2000)]
        public string DescribeInfo { get; set; }

        [StringLength(2000)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsDefault { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AddUserId { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime AddTime { get; set; }

        public int? UpdateUserId { get; set; }

        public DateTime? UpdateTime { get; set; }

        [StringLength(50)]
        public string AddUserName { get; set; }

        [StringLength(50)]
        public string UpdateUserName { get; set; }

        [StringLength(50)]
        public string GoodsTypeName { get; set; }
    }
}
