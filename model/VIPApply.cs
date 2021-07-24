namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VIPApply")]
    public partial class VIPApply
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        [Required]
        [StringLength(10)]
        public string Status { get; set; }

        [Column(TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        public int ConfirmLevel { get; set; }

        public int OperatorId { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(200)]
        public string InvoiceName { get; set; }

        [StringLength(50)]
        public string InvoiceType { get; set; }

        [StringLength(50)]
        public string InvoiceContent { get; set; }

        public bool IsDelete { get; set; }

        [StringLength(50)]
        public string InvoiceCategory { get; set; }

        [StringLength(200)]
        public string EmailForInvoice { get; set; }

        public string InvoiceInfo { get; set; }

        [StringLength(20)]
        public string PayType { get; set; }

        public int DeptId { get; set; }

        public int LogisticsId { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }
    }
}
