namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerInvoiceInfo")]
    public partial class CustomerInvoiceInfo
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [StringLength(50)]
        public string InvoiceTaxNo { get; set; }

        [StringLength(500)]
        public string InvoiceAddress { get; set; }

        [StringLength(50)]
        public string InvoicePhone { get; set; }

        [StringLength(100)]
        public string InvoiceBank { get; set; }

        [StringLength(100)]
        public string InvoiceAccount { get; set; }

        [StringLength(500)]
        public string InvoiceMemo { get; set; }

        [Required]
        [StringLength(100)]
        public string MemberName { get; set; }
    }
}
