namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_Plat
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int I_ProviderId { get; set; }

        public bool? IsPostData { get; set; }

        [StringLength(50)]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
