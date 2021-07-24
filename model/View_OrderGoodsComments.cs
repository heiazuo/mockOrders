namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_OrderGoodsComments
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Type { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Score { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(500)]
        public string CommentContent { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Status { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Recommend { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool IsAnonymous { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime AddTime { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(500)]
        public string Label { get; set; }

        public int? OrderId { get; set; }

        public int? Num { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        public int? MemberBranchId { get; set; }

        public int? GoodsBranchId { get; set; }

        public bool? IsComment { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderDetailId { get; set; }

        public DateTime? OrderTime { get; set; }

        [Column(TypeName = "money")]
        public decimal? SumMoney { get; set; }

        [StringLength(50)]
        public string PayType { get; set; }

        [StringLength(50)]
        public string PayStatus { get; set; }

        [StringLength(50)]
        public string ServiceStatus { get; set; }

        [StringLength(50)]
        public string DeliveryStatus { get; set; }

        public bool? IsEnable { get; set; }

        public bool? IsDelete { get; set; }

        [StringLength(500)]
        public string DisplayName { get; set; }
    }
}
