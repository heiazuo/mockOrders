namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PurchaseDetail")]
    public partial class PurchaseDetail
    {
        public int Id { get; set; }

        public int PurchaseId { get; set; }

        public int GoodsId { get; set; }

        [Column(TypeName = "money")]
        public decimal BillsPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal InPrice { get; set; }

        public int Num { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public int ReceivedNum { get; set; }

        public bool IsEmergency { get; set; }

        public int SupplierNum { get; set; }

        [Column(TypeName = "date")]
        public DateTime DelayDate { get; set; }

        [StringLength(50)]
        public string PurchaseStatus { get; set; }

        public string DetailMemo { get; set; }

        public bool IsCustomGoods { get; set; }

        public int OrderDetailId { get; set; }

        public int OldPurchaseId { get; set; }

        public bool? IsDonvvSupply { get; set; }

        [StringLength(50)]
        public string DonvvBrandId { get; set; }

        [StringLength(100)]
        public string DonvvBrandName { get; set; }

        public bool IsGift { get; set; }

        public int RefundNum { get; set; }

        [StringLength(20)]
        public string InvoiceType { get; set; }

        [Column(TypeName = "money")]
        public decimal TaxRate { get; set; }

        [Column(TypeName = "money")]
        public decimal TaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal NoTaxAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal NoTaxInPrice { get; set; }

        public bool IsTotalAmount { get; set; }
    }
}
