namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerPreReceiveMoney")]
    public partial class CustomerPreReceiveMoney
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int CustomerId { get; set; }

        [Required]
        [StringLength(200)]
        public string CustomerName { get; set; }

        public int OrderStatementId { get; set; }

        [Column(TypeName = "money")]
        public decimal InitialBalance { get; set; }

        [Required]
        [StringLength(10)]
        public string Operate { get; set; }

        [Column(TypeName = "money")]
        public decimal PreReceiveMoney { get; set; }

        [Column(TypeName = "money")]
        public decimal ReceiveMoney { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        public int OperatorId { get; set; }

        [Required]
        [StringLength(50)]
        public string OperatorName { get; set; }

        [Column(TypeName = "text")]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string PayType { get; set; }

        [Required]
        [StringLength(50)]
        public string ReceiveAccount { get; set; }

        public DateTime ActualPayTime { get; set; }
    }
}
