namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(100)]
        public string ShortName { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [StringLength(100)]
        public string EmployeesNum { get; set; }

        [StringLength(100)]
        public string Province { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(6)]
        public string PostCode { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(200)]
        public string Website { get; set; }

        [Required]
        [StringLength(50)]
        public string RegisterMethod { get; set; }

        public int UserId { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime UpdateTime { get; set; }

        public int Level { get; set; }

        public int SalesId { get; set; }

        public int ServiceId { get; set; }

        public int StatementManId { get; set; }

        public int OrderDiscount { get; set; }

        [StringLength(200)]
        public string OrderMemo { get; set; }

        public int OrderPrintNum { get; set; }

        [StringLength(200)]
        public string StoreMemo { get; set; }

        [StringLength(200)]
        public string StatementMemo { get; set; }

        [StringLength(50)]
        public string PayType { get; set; }

        [StringLength(50)]
        public string PayMethod { get; set; }

        public int Credit { get; set; }

        public int CreditDays { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceType { get; set; }

        [StringLength(200)]
        public string InvoiceName { get; set; }

        [StringLength(50)]
        public string InvoiceTaxNo { get; set; }

        [StringLength(500)]
        public string InvoiceAddress { get; set; }

        [StringLength(50)]
        public string InvoicePhone { get; set; }

        [StringLength(100)]
        public string InvoiceBank { get; set; }

        [StringLength(100)]
        public string InvoiceBankAccount { get; set; }

        [Required]
        [StringLength(100)]
        public string InvoiceContent { get; set; }

        [StringLength(200)]
        public string InvoiceMemo { get; set; }

        public bool IsOrdering { get; set; }

        public bool IsMultiAccount { get; set; }

        public bool IsComfirmOrder { get; set; }

        public int ConfirmLevel { get; set; }

        public bool IsCounter { get; set; }

        public bool IsBuyOutCounter { get; set; }

        public bool IsBudget { get; set; }

        public bool IsStoreManager { get; set; }

        [StringLength(500)]
        public string PY { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceCategory { get; set; }

        [StringLength(200)]
        public string EmailForInvoice { get; set; }

        public bool IsPublic { get; set; }

        public int PrintTemplateId { get; set; }

        public bool OnlyServiceOrder { get; set; }

        public bool OnlyStatementManCheck { get; set; }

        public bool? IsDisable { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        public bool IsBalance { get; set; }

        public int BalanceType { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public bool? LimitOrderByBalance { get; set; }

        [StringLength(1000)]
        public string Memo { get; set; }

        public int? WinformDeliveryTemplateId { get; set; }

        [StringLength(50)]
        public string Tpn { get; set; }

        [StringLength(50)]
        public string TpName { get; set; }
    }
}
