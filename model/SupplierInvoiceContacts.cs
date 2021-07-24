namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SupplierInvoiceContacts
    {
        public int Id { get; set; }

        public int SupplierInvoiceId { get; set; }

        [StringLength(200)]
        public string FileUrl { get; set; }

        [StringLength(100)]
        public string Remarks { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
