namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_MemberDeliveryLine
    {
        public int? BranchId { get; set; }

        [StringLength(50)]
        public string LineName { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string RealName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string Address { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? LineId { get; set; }
    }
}
