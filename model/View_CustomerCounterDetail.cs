namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_CustomerCounterDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CounterId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal VIPPrice { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Level { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool IsSales { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime AddTime { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(100)]
        public string ShortName { get; set; }
    }
}
