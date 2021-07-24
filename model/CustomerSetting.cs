namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomerSetting")]
    public partial class CustomerSetting
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Alias { get; set; }

        [Required]
        [StringLength(2000)]
        public string Logo { get; set; }

        [Required]
        [StringLength(2000)]
        public string Image { get; set; }

        public int Tenant { get; set; }
    }
}
