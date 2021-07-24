namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderAfterSaleFlow")]
    public partial class OrderAfterSaleFlow
    {
        public int Id { get; set; }

        public int AfterSaleId { get; set; }

        public int OrderId { get; set; }

        [Required]
        [StringLength(50)]
        public string OperateType { get; set; }

        public int OperateUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string OperateUserName { get; set; }

        [Required]
        [StringLength(500)]
        public string OperateMessage { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        [Required]
        [StringLength(50)]
        public string DisplayStatus { get; set; }

        [Required]
        [StringLength(50)]
        public string InnerStatus { get; set; }

        public DateTime AddTime { get; set; }
    }
}
