namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_TransferPicking
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TransferId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PickingUserId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DistributeUserId { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OutBranchId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OutStoreId { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OutStoreUserId { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime OutStoreDate { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string OutStatus { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LogisticsInfomationId { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InBranchId { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InStoreId { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InStoreUserId { get; set; }

        [Key]
        [Column(Order = 14)]
        public DateTime InStoreDate { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(50)]
        public string InStatus { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(500)]
        public string Memo { get; set; }

        public DateTime? AddTime { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RowNum { get; set; }

        [Key]
        [Column(Order = 18, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool IsDelete { get; set; }

        [Key]
        [Column(Order = 21)]
        public bool IsChecked { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(100)]
        public string OutBranchName { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(100)]
        public string InBranchName { get; set; }

        [StringLength(50)]
        public string OutStoreName { get; set; }

        [StringLength(50)]
        public string InStoreName { get; set; }

        [StringLength(50)]
        public string InStoreUserName { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string PickingUserName { get; set; }
    }
}
