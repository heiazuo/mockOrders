namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_OrderDistributionDetail
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
        public int PBranchId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OriginalBranchId { get; set; }

        [Key]
        [Column(Order = 4)]
        public double ParentReceiveRate { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderDetailId { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderDistributionId { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "money")]
        public decimal Amount { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool IsDelete { get; set; }

        public bool? IsPicked { get; set; }

        public DateTime? PickTime { get; set; }

        public bool? IsPrinted { get; set; }

        public DateTime? PrintTime { get; set; }

        public bool? IsDelivered { get; set; }

        public DateTime? DeliveryTime { get; set; }

        public bool? IsArrived { get; set; }

        public DateTime? ArriveTime { get; set; }

        public DateTime? AllocationTime { get; set; }

        public bool? IsLocked { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal OrgPrice { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "money")]
        public decimal OrgAmount { get; set; }

        public string SingleRemark { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DisplayNum { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string DisplayUnit { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "money")]
        public decimal DisplayPrice { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "money")]
        public decimal GrossProfit { get; set; }

        [StringLength(50)]
        public string GrossProfitPercent { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(500)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeId { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrandId { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(50)]
        public string Unit { get; set; }
    }
}
