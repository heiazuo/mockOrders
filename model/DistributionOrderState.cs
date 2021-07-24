namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DistributionOrderState")]
    public partial class DistributionOrderState
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int OrderId { get; set; }

        public bool IsPicked { get; set; }

        public DateTime? PickTime { get; set; }

        public bool IsPrinted { get; set; }

        public DateTime? PrintTime { get; set; }

        public bool IsDelivered { get; set; }

        public DateTime? DeliveryTime { get; set; }

        public bool IsArrived { get; set; }

        public DateTime? ArriveTime { get; set; }

        public DateTime? AllocationTime { get; set; }

        public bool IsLocked { get; set; }

        public bool IsConverted { get; set; }

        public bool IsDelete { get; set; }

        public DateTime? ServiceResponseTime { get; set; }

        public int ReceiveMoneyStatus { get; set; }

        public int InvoiceStatus { get; set; }

        [Column(TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Column(TypeName = "money")]
        public decimal ReceiveChargeOff { get; set; }

        [Column(TypeName = "money")]
        public decimal InvoiceChargeOff { get; set; }
    }
}
