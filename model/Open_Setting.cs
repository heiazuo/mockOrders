namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Open_Setting
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int PlatId { get; set; }

        [Required]
        [StringLength(50)]
        public string PlatName { get; set; }

        public bool IsSyncCategory { get; set; }

        public bool IsSyncGoods { get; set; }

        public bool IsSyncCustomer { get; set; }

        public bool IsSucceed { get; set; }

        public bool IsOpen { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }

        public bool IsSyncCounter { get; set; }

        public bool IsSyncOrder { get; set; }
    }
}
