namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberTemp")]
    public partial class MemberTemp
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int DeptId { get; set; }

        [StringLength(100)]
        public string LoginName { get; set; }

        [StringLength(50)]
        public string PassWord { get; set; }

        [Required]
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

        public int LoginNumber { get; set; }

        public double Point { get; set; }

        [StringLength(20)]
        public string Province { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string PostCode { get; set; }

        [Required]
        [StringLength(50)]
        public string RegisterMethod { get; set; }

        public DateTime RegisterDate { get; set; }

        public int ConfirmLevel { get; set; }

        public int VIPCounterLevel { get; set; }

        public bool IsMainContact { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsOrderAuthority { get; set; }

        public bool IsEnable { get; set; }

        public bool IsCheckMobile { get; set; }

        public bool IsCheckEmail { get; set; }

        public DateTime UpdateTime { get; set; }

        public int BranchId { get; set; }

        [StringLength(20)]
        public string Role { get; set; }

        public bool IsForbidden { get; set; }

        public bool IsDerectApply { get; set; }

        public bool IsEmailApply { get; set; }

        public bool IsOrderForManyDepts { get; set; }

        public bool IsDelete { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        public bool IsBalance { get; set; }
    }
}
