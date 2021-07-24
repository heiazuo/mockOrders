namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_InventoryApply
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string StoreZone { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NowNum { get; set; }

        public int? OldNum { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime CreateAt { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CreateBy { get; set; }

        [StringLength(100)]
        public string Remarks { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int State { get; set; }

        public DateTime? AuditAt { get; set; }

        public int? AuditBy { get; set; }

        [StringLength(50)]
        public string AuditName { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string CreateName { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(500)]
        public string GoodsName { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string StoreName { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(50)]
        public string Code { get; set; }
    }
}
