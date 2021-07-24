namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_PurchaseLog
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
        [StringLength(50)]
        public string PurchaseType { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string PurchaseStatus { get; set; }

        [Column(TypeName = "text")]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(200)]
        public string Operate { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool IsInner { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string UserName { get; set; }
    }
}
