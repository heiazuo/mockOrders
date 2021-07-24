namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_DeliveryLineCustomer
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
        [StringLength(50)]
        public string LineName { get; set; }

        [StringLength(200)]
        public string LineRange { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }
    }
}
