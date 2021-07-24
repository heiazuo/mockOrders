namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Customer
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 2)]
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

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string RegisterMethod { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime AddTime { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Level { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SalesId { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ServiceId { get; set; }

        [StringLength(50)]
        public string ServiceName { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StatementManId { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderDiscount { get; set; }

        [StringLength(200)]
        public string OrderMemo { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderPrintNum { get; set; }

        [StringLength(200)]
        public string StoreMemo { get; set; }

        [StringLength(200)]
        public string StatementMemo { get; set; }

        [StringLength(50)]
        public string PayType { get; set; }

        [StringLength(50)]
        public string PayMethod { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Credit { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreditDays { get; set; }

        [Key]
        [Column(Order = 15)]
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

        [Key]
        [Column(Order = 16)]
        [StringLength(100)]
        public string InvoiceContent { get; set; }

        [StringLength(200)]
        public string InvoiceMemo { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool IsOrdering { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool IsMultiAccount { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool IsComfirmOrder { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConfirmLevel { get; set; }

        [Key]
        [Column(Order = 21)]
        public bool IsCounter { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool IsBuyOutCounter { get; set; }

        [Key]
        [Column(Order = 23)]
        public bool IsBudget { get; set; }

        [Key]
        [Column(Order = 24)]
        public bool IsStoreManager { get; set; }

        [StringLength(500)]
        public string PY { get; set; }

        [StringLength(50)]
        public string SalesName { get; set; }

        [Key]
        [Column(Order = 25)]
        public bool IsPublic { get; set; }

        public bool? IsDisable { get; set; }

        [StringLength(50)]
        public string MemberRealName { get; set; }

        [StringLength(100)]
        public string DeptName { get; set; }
    }
}
