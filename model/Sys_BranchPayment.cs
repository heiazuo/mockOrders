namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_BranchPayment
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(300)]
        public string ImgUrl { get; set; }

        public string Remark { get; set; }

        public int? Type { get; set; }

        public int? PoundageType { get; set; }

        public decimal? PoundageAmount { get; set; }

        [StringLength(50)]
        public string ApiPath { get; set; }

        [StringLength(300)]
        public string RedirectUrl { get; set; }

        [StringLength(300)]
        public string ReturnUrl { get; set; }

        [StringLength(300)]
        public string NotifyUrl { get; set; }

        public int? SortId { get; set; }

        public int? IsOk { get; set; }

        public DateTime? AddTime { get; set; }
    }
}
