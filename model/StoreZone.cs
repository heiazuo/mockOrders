namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StoreZone")]
    public partial class StoreZone
    {
        public int Id { get; set; }

        public int StoreId { get; set; }

        [Required]
        [StringLength(200)]
        public string Code { get; set; }

        [Required]
        [StringLength(200)]
        public string PCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [StringLength(200)]
        public string Memo { get; set; }

        public DateTime UpdateTime { get; set; }

        public int PrintNum { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
