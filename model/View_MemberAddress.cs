namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_MemberAddress
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(20)]
        public string Province { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        public string Area { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string TelPhone { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool IsDefault { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool IsDelete { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptId { get; set; }
    }
}
