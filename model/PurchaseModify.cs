namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseModify")]
    public partial class PurchaseModify
    {
        public int Id { get; set; }

        public int PurchaseId { get; set; }

        public int GoodsId { get; set; }

        public int OldNum { get; set; }

        public int NewNum { get; set; }

        [Column(TypeName = "money")]
        public decimal OldPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal NewPrice { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }

        [Column(TypeName = "text")]
        public string Memo { get; set; }

        [Column(TypeName = "money")]
        public decimal OldTaxRate { get; set; }

        [Column(TypeName = "money")]
        public decimal NewTaxRate { get; set; }

        [Column(TypeName = "money")]
        public decimal OldNoTaxPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal NewNoTaxPrice { get; set; }
    }
}
