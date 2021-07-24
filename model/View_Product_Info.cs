namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Product_Info
    {
        [Key]
        [Column(Order = 0)]
        public bool IsChecked { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "text")]
        public string Params { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(500)]
        public string SourceUrl { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeId { get; set; }

        [StringLength(50)]
        public string TypeName { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(500)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PhotoNum { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DetailPhotoNum { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DonvvSKU { get; set; }

        public int? DataSource { get; set; }
    }
}
