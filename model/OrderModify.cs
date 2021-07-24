namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderModify")]
    public partial class OrderModify
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int GoodsId { get; set; }

        public int OldNum { get; set; }

        public int NewNum { get; set; }

        [Column(TypeName = "money")]
        public decimal OldPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal NewPrice { get; set; }

        [Required]
        [StringLength(50)]
        public string PurchaseType { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool IsNeedCollect { get; set; }

        public int NeedToPurchaseId { get; set; }

        [Required]
        [StringLength(50)]
        public string DisplayUnit { get; set; }

        [Column(TypeName = "text")]
        public string Memo { get; set; }

        [Column(TypeName = "money")]
        public decimal OldTaxRate { get; set; }

        [Column(TypeName = "money")]
        public decimal NewTaxRate { get; set; }
    }
}
