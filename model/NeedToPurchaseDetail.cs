namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NeedToPurchaseDetail")]
    public partial class NeedToPurchaseDetail
    {
        public int Id { get; set; }

        public int NeedToPurchaseId { get; set; }

        public int GoodsId { get; set; }

        [Required]
        public string GoodsMemo { get; set; }

        public int Num { get; set; }

        public int LackNum { get; set; }

        [StringLength(100)]
        public string PurchaseType { get; set; }

        [StringLength(200)]
        public string PurchaseMemo { get; set; }

        [StringLength(100)]
        public string CreditCard { get; set; }

        public bool Emergency { get; set; }

        public int SupplierId { get; set; }

        public int? UserId { get; set; }

        public decimal? InPrice { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool IsCustomGoods { get; set; }

        public int OrderDetailId { get; set; }

        public string Memo { get; set; }

        public int StoreId { get; set; }
    }
}
