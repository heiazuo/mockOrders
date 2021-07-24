namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchBankInfo
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(100)]
        public string AccountName { get; set; }

        [Required]
        [StringLength(100)]
        public string BankName { get; set; }

        [Required]
        [StringLength(100)]
        public string AccountNumber { get; set; }

        public DateTime UpdateTime { get; set; }

        public bool IsDefault { get; set; }

        [Column(TypeName = "money")]
        public decimal? Balance { get; set; }

        public bool? IsEnable { get; set; }

        [Required]
        [StringLength(64)]
        public string TelephoneNumber { get; set; }

        [Required]
        [StringLength(256)]
        public string Address { get; set; }

        [Required]
        [StringLength(128)]
        public string TaxNumber { get; set; }
    }
}
