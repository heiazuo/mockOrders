namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_OrderStatement
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal PaidMoney { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string PayStatus { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IsCrossInvoice { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PrintNum { get; set; }

        [StringLength(50)]
        public string InvoiceType { get; set; }

        [StringLength(50)]
        public string InvoiceStatus { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal InvoiceMoney { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal NeedToInvoice { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(200)]
        public string CustomerName { get; set; }

        [StringLength(100)]
        public string ShortName { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(100)]
        public string Province { get; set; }

        [StringLength(200)]
        public string InvoiceMemo { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(100)]
        public string InvoiceContent { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "money")]
        public decimal ChargeOff { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "money")]
        public decimal SumGoodsAmount { get; set; }
    }
}
