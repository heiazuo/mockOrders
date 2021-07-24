namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_OrderAfterSale
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
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(500)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string ApplyType { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApplyNum { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string ApplyReason { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(500)]
        public string QuestionDescribe { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(50)]
        public string ReturnWay { get; set; }

        [StringLength(500)]
        public string PickupAddress { get; set; }

        public DateTime? PickupDate { get; set; }

        [StringLength(500)]
        public string ReceiveAddress { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApplyUserId { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string ApplyUserName { get; set; }

        [Key]
        [Column(Order = 15)]
        public DateTime ApplyTime { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string ContactWay { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(50)]
        public string DisplayStatus { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(50)]
        public string InnerStatus { get; set; }

        public int? OperateUserId { get; set; }

        [StringLength(50)]
        public string OperateUserName { get; set; }

        [StringLength(50)]
        public string OperateType { get; set; }

        [StringLength(500)]
        public string OperateMessage { get; set; }

        public DateTime? OperateTime { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool IsEvaluate { get; set; }

        [Key]
        [Column(Order = 20)]
        public DateTime Updatetime { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderDetailId { get; set; }

        [StringLength(200)]
        public string CustomerName { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OldNum { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(500)]
        public string HomeImage { get; set; }
    }
}
