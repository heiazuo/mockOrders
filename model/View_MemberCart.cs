namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_MemberCart
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(500)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MinimumQuantity { get; set; }

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
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(500)]
        public string HomeImage { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal InPrice { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool IsEnable { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool IsChecked { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Multiples { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DisplayNum { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string DisplayUnit { get; set; }
    }
}
