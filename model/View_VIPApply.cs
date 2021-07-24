namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_VIPApply
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Status { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string Address { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConfirmLevel { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OperatorId { get; set; }

        [StringLength(500)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 7)]
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

        [Key]
        [Column(Order = 8)]
        public bool IsDelete { get; set; }

        [StringLength(50)]
        public string InvoiceCategory { get; set; }

        [StringLength(200)]
        public string EmailForInvoice { get; set; }

        public string InvoiceInfo { get; set; }

        [StringLength(20)]
        public string PayType { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptId { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string MemberName { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(100)]
        public string DeptName { get; set; }
    }
}
