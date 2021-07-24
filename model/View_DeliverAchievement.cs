namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_DeliverAchievement
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime OrderTime { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string PickUser { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime PickTime { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string DeliveryUser { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime DeliveryFinishTime { get; set; }

        public int? DeliveryDays { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }
    }
}
