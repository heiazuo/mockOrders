namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceRequireDetail")]
    public partial class InvoiceRequireDetail
    {
        public int Id { get; set; }

        public int InvoiceRequireId { get; set; }

        public int OrderDetailId { get; set; }

        public int GoodsInvoiceNum { get; set; }

        public int? StatementId { get; set; }

        public int? OrderId { get; set; }

        public decimal? InvoiceMoney { get; set; }

        [Column(TypeName = "money")]
        public decimal? TaxRate { get; set; }

        [StringLength(500)]
        public string TaxCode { get; set; }

        [StringLength(500)]
        public string DisplayName { get; set; }

        public int GoodsId { get; set; }

        public decimal? Price { get; set; }
    }
}
