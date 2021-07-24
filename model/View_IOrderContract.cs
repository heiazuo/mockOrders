namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_IOrderContract
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? OrderId { get; set; }

        public int? ContractId { get; set; }

        [StringLength(500)]
        public string ContractNum { get; set; }

        public DateTime? DeliveryTime { get; set; }

        [StringLength(50)]
        public string ReceiveUser { get; set; }

        public int? BranchId { get; set; }

        public DateTime? CreateTime { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }

        [StringLength(100)]
        public string ContractName { get; set; }

        [StringLength(100)]
        public string BankName { get; set; }

        [StringLength(100)]
        public string BankAccount { get; set; }

        [StringLength(50)]
        public string ConNum { get; set; }

        [Column(TypeName = "text")]
        public string Sign { get; set; }

        [Column(TypeName = "text")]
        public string Signature { get; set; }

        [StringLength(1000)]
        public string CAddress { get; set; }

        [StringLength(100)]
        public string CFax { get; set; }

        [StringLength(100)]
        public string CompanyNum { get; set; }

        [StringLength(100)]
        public string CTel { get; set; }
    }
}
