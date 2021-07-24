namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_VIPApplyDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ApplyId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string Status { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "money")]
        public decimal SumMoney { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GoodsId { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Num { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal Price { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(500)]
        public string DisplayName { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string Unit { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool IsDelete { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(500)]
        public string HomeImage { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string MemberName { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberDeptId { get; set; }

        [StringLength(100)]
        public string MemberDeptName { get; set; }

        [StringLength(100)]
        public string MemberDeptCode { get; set; }

        [StringLength(100)]
        public string MemberDeptPCode { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConfirmLevel { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MinimumQuantity { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DisplayNum { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(50)]
        public string DisplayUnit { get; set; }

        [Key]
        [Column(Order = 19, TypeName = "money")]
        public decimal DisplayPrice { get; set; }
    }
}
