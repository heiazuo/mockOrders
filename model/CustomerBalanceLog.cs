namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerBalanceLog")]
    public partial class CustomerBalanceLog
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int CustomerId { get; set; }

        [Required]
        [StringLength(200)]
        public string CustomerName { get; set; }

        public int Direction { get; set; }

        [Column(TypeName = "money")]
        public decimal Change { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public int? DeptId { get; set; }

        [StringLength(200)]
        public string DeptName { get; set; }

        public int? UserId { get; set; }

        [StringLength(200)]
        public string UserName { get; set; }

        public int? RelationId { get; set; }

        public DateTime CreateDate { get; set; }

        public int CreationId { get; set; }

        [StringLength(200)]
        public string Remark { get; set; }
    }
}
