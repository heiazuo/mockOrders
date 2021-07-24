namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransferReceiveMoney")]
    public partial class TransferReceiveMoney
    {
        public int Id { get; set; }

        public int TransferStatementId { get; set; }

        [Column(TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Column(TypeName = "money")]
        public decimal ReceiveMoney { get; set; }

        public DateTime? ReceiveDate { get; set; }

        [Required]
        [StringLength(50)]
        public string PayType { get; set; }

        [StringLength(200)]
        public string Memo { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
