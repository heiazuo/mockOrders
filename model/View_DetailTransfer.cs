namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_DetailTransfer
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OutBranchId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OutStoreId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OutStoreUserId { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime OutStoreDate { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string OutStatus { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LogisticsInfomationId { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InBranchId { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InStoreId { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InStoreUserId { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime InStoreDate { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string InStatus { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(500)]
        public string Memo { get; set; }

        [Key]
        [Column(Order = 13)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RowNum { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool IsDelete { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool IsChecked { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(100)]
        public string OutBranchName { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(100)]
        public string InBranchName { get; set; }

        [StringLength(50)]
        public string OutStoreName { get; set; }

        [StringLength(50)]
        public string InStoreName { get; set; }

        [StringLength(50)]
        public string OutStoreUserName { get; set; }

        [StringLength(50)]
        public string InStoreUserName { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 21)]
        public DateTime AddTime { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool IsArchive { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 25, TypeName = "money")]
        public decimal Amount { get; set; }

        [Key]
        [Column(Order = 26)]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PickNum { get; set; }

        [Key]
        [Column(Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReceivedNum { get; set; }

        [Key]
        [Column(Order = 29)]
        [StringLength(50)]
        public string ReceivedStatus { get; set; }

        [StringLength(500)]
        public string SingleRemark { get; set; }

        [Key]
        [Column(Order = 30)]
        [StringLength(1000)]
        public string DisPlayName { get; set; }

        [Key]
        [Column(Order = 31)]
        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 32)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DetailId { get; set; }
    }
}
