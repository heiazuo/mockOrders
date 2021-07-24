namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderInvoiceInfo")]
    public partial class OrderInvoiceInfo
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int Type { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Content { get; set; }

        [Required]
        [StringLength(50)]
        public string TaxNo { get; set; }

        [Required]
        [StringLength(500)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(100)]
        public string Bank { get; set; }

        [Required]
        [StringLength(100)]
        public string BankAccount { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }
    }
}
