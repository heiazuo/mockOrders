namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Open_Project
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public int SettingId { get; set; }

        public int PlatId { get; set; }

        [Required]
        [StringLength(50)]
        public string BaseApi { get; set; }

        [Required]
        [StringLength(255)]
        public string AppKey { get; set; }

        [Required]
        [StringLength(255)]
        public string AppSecret { get; set; }

        [StringLength(255)]
        public string AccessToken { get; set; }

        public long? ExpiredTime { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? UpdateAt { get; set; }
    }
}
