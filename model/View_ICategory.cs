namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_ICategory
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int I_PlatId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string I_TypeCode { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string I_TypeName { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string I_Category { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeId { get; set; }

        [StringLength(50)]
        public string TypeName { get; set; }

        public DateTime? UpdateTime { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal Discount { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string PCode { get; set; }

        public decimal? Discount2 { get; set; }

        public decimal? Discount3 { get; set; }

        public decimal? Discount4 { get; set; }
    }
}
