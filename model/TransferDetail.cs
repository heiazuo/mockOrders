namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransferDetail")]
    public partial class TransferDetail
    {
        public int Id { get; set; }

        public int TransferId { get; set; }

        public int GoodsId { get; set; }

        public int Num { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public decimal Price { get; set; }

        public int PickNum { get; set; }

        public int ReceivedNum { get; set; }

        [Required]
        [StringLength(50)]
        public string ReceivedStatus { get; set; }

        [StringLength(500)]
        public string SingleRemark { get; set; }
    }
}
