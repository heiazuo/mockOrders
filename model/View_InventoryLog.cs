namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_InventoryLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StoreId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Operate { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RelationId { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OldNum { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal AC { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "money")]
        public decimal AFC { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(100)]
        public string OldStoreZone { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(100)]
        public string StoreZone { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NewNum { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(500)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool IsCustomGoods { get; set; }
    }
}
