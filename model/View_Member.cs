namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_Member
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptId { get; set; }

        [StringLength(100)]
        public string LoginName { get; set; }

        [StringLength(50)]
        public string PassWord { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(50)]
        public string IM { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LoginNumber { get; set; }

        [Key]
        [Column(Order = 5)]
        public double Point { get; set; }

        [StringLength(20)]
        public string Province { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string PostCode { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string RegisterMethod { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime RegisterDate { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConfirmLevel { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VIPCounterLevel { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool IsMainContact { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool IsAdmin { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool IsOrderAuthority { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool IsEnable { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool IsCheckMobile { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool IsCheckEmail { get; set; }

        [Key]
        [Column(Order = 17)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [StringLength(20)]
        public string Role { get; set; }

        [StringLength(200)]
        public string CustomerName { get; set; }

        [StringLength(100)]
        public string ShortName { get; set; }

        [StringLength(100)]
        public string DeptName { get; set; }

        [StringLength(100)]
        public string Code { get; set; }

        [StringLength(100)]
        public string PCode { get; set; }

        public int? Level { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool IsForbidden { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool IsDerectApply { get; set; }
    }
}
