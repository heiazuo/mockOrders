namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Config
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(500)]
        public string Value { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }
    }
}
