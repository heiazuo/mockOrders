namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_PurchaseStatement
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
        public int SupplierId { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal PaidMoney { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string PayStatus { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime UpdateTime { get; set; }

        [StringLength(200)]
        public string SupplierName { get; set; }

        [StringLength(50)]
        public string LinkMan { get; set; }

        [StringLength(100)]
        public string Mobile { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(100)]
        public string ShortName { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Expr1 { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal ChargeOff { get; set; }
    }
}
