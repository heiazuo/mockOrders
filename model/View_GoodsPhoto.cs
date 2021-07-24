namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_GoodsPhoto
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
        [StringLength(500)]
        public string PhotoUrl { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsHomeImage { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool IsDetailPhoto { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Sort { get; set; }

        public int? UserId { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime UpdateTime { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(500)]
        public string Photo250Url { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(500)]
        public string Photo100Url { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ParentId { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ImgServerId { get; set; }
    }
}
