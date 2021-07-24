namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_Project
    {
        public int Id { get; set; }

        public int I_PlatId { get; set; }

        public int BranchId { get; set; }

        public int ServerId { get; set; }

        [Required]
        [StringLength(100)]
        public string AppKey { get; set; }

        [Required]
        [StringLength(100)]
        public string AppSecret { get; set; }

        [StringLength(100)]
        public string AccessToken { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public DateTime UpdateTime { get; set; }

        [StringLength(100)]
        public string client_id { get; set; }

        [StringLength(5000)]
        public string PrivateKey { get; set; }
    }
}
