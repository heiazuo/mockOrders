namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_SupplierDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PurchaseId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal BillsPrice { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal InPrice { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal Amount { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceivedNum { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool IsEmergency { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SupplierNum { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "date")]
        public DateTime DelayDate { get; set; }

        [StringLength(50)]
        public string PurchaseStatus { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(200)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(500)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string Unit { get; set; }
    }
}
