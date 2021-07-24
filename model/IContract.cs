namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IContract")]
    public partial class IContract
    {
        public int Id { get; set; }

        public int? BranchId { get; set; }

        [StringLength(100)]
        public string ContractName { get; set; }

        [StringLength(100)]
        public string BankName { get; set; }

        [StringLength(100)]
        public string BankAccount { get; set; }

        [StringLength(50)]
        public string ConNum { get; set; }

        [Column(TypeName = "text")]
        public string Signature { get; set; }

        [Column(TypeName = "text")]
        public string Sign { get; set; }

        [StringLength(1000)]
        public string Address { get; set; }

        [StringLength(100)]
        public string Fax { get; set; }

        [StringLength(100)]
        public string Tel { get; set; }

        [StringLength(100)]
        public string CompanyNum { get; set; }

        public DateTime? UpdateTime { get; set; }
    }
}
