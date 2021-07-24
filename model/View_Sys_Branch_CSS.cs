namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Sys_Branch_CSS
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
        public int CssId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Type { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(200)]
        public string CssFileName { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(200)]
        public string Memo { get; set; }
    }
}
