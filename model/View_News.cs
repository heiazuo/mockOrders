namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_News
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
        [StringLength(300)]
        public string Title { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NewsTypeId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Author { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime PublishDate { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "text")]
        public string Content { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool IsTop { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(100)]
        public string TypeName { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool IsEnable { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TypeBranchId { get; set; }
    }
}
