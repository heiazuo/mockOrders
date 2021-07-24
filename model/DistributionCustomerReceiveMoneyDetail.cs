namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DistributionCustomerReceiveMoneyDetail")]
    public partial class DistributionCustomerReceiveMoneyDetail
    {
        public int Id { get; set; }

        public int ReceiveMoneyId { get; set; }

        public int OrderId { get; set; }

        public int GoodsId { get; set; }

        public int Num { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        [Column(TypeName = "money")]
        public decimal ChargeOffAmount { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(200)]
        public string GoodsName { get; set; }

        [Required]
        [StringLength(50)]
        public string Unit { get; set; }

        public bool IsDelete { get; set; }
    }
}
