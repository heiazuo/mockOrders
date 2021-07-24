namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_LogisticsCompany
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
        [StringLength(100)]
        public string ShortName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool IsDefault { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool IsDisable { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupportedId { get; set; }

        [StringLength(200)]
        public string LogisticsCompany { get; set; }

        [StringLength(200)]
        public string Code { get; set; }

        [StringLength(50)]
        public string CountryCode { get; set; }

        [StringLength(50)]
        public string Type { get; set; }
    }
}
