namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderReceiveMoney")]
    public partial class OrderReceiveMoney
    {
        public int Id { get; set; }

        public int OrderStatementId { get; set; }

        [Column(TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Column(TypeName = "money")]
        public decimal ReceiveMoney { get; set; }

        public DateTime? ReceiveDate { get; set; }

        [Required]
        [StringLength(50)]
        public string PayType { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string ReceiveAccount { get; set; }

        public int PreReceiveMoneyId { get; set; }
    }
}
