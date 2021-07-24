namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Supplier")]
    public partial class Supplier
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public bool IsEnable { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string ShortName { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(50)]
        public string Attitude { get; set; }

        [StringLength(50)]
        public string InvoiceType { get; set; }

        [StringLength(50)]
        public string PayType { get; set; }

        [StringLength(50)]
        public string LinkMan { get; set; }

        [StringLength(100)]
        public string TelPhone { get; set; }

        [StringLength(100)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string QQ { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(200)]
        public string MainBrand { get; set; }

        [StringLength(500)]
        public string Major { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(200)]
        public string PassWord { get; set; }

        [StringLength(200)]
        public string PY { get; set; }

        public bool IsPublic { get; set; }

        public int AddUserId { get; set; }

        [Required]
        [StringLength(50)]
        public string SupplierTaxNo { get; set; }

        [Required]
        [StringLength(500)]
        public string OpeningBank { get; set; }

        [Required]
        [StringLength(50)]
        public string BankAccount { get; set; }

        public int ExpiredPayment { get; set; }

        [Required]
        [StringLength(50)]
        public string AddUserName { get; set; }

        [StringLength(50)]
        public string DonvvSupplierId { get; set; }

        [StringLength(255)]
        public string Remark { get; set; }
    }
}
