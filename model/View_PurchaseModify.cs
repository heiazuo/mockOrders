namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_PurchaseModify
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PurchaseId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OldNum { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NewNum { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal OldPrice { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal NewPrice { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime UpdateTime { get; set; }

        [Column(TypeName = "text")]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(500)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string Unit { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "money")]
        public decimal OldTaxRate { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "money")]
        public decimal NewTaxRate { get; set; }

        [Key]
        [Column(Order = 13, TypeName = "money")]
        public decimal OldNoTaxPrice { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "money")]
        public decimal NewNoTaxPrice { get; set; }
    }
}
