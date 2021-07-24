namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderAfterSale")]
    public partial class OrderAfterSale
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public int MemberId { get; set; }

        public int GoodsId { get; set; }

        [Required]
        [StringLength(500)]
        public string DisplayName { get; set; }

        [Required]
        [StringLength(50)]
        public string Unit { get; set; }

        [Required]
        [StringLength(50)]
        public string ApplyType { get; set; }

        public int ApplyNum { get; set; }

        [Required]
        [StringLength(50)]
        public string ApplyReason { get; set; }

        [Required]
        [StringLength(500)]
        public string QuestionDescribe { get; set; }

        [Required]
        [StringLength(50)]
        public string ReturnWay { get; set; }

        [StringLength(500)]
        public string PickupAddress { get; set; }

        public DateTime? PickupDate { get; set; }

        [StringLength(500)]
        public string ReceiveAddress { get; set; }

        public int ApplyUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string ApplyUserName { get; set; }

        public DateTime ApplyTime { get; set; }

        [Required]
        [StringLength(50)]
        public string ContactWay { get; set; }

        [Required]
        [StringLength(50)]
        public string DisplayStatus { get; set; }

        [Required]
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

        public bool IsEvaluate { get; set; }

        public DateTime Updatetime { get; set; }

        public int OrderDetailId { get; set; }
    }
}
