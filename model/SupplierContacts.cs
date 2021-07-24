namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SupplierContacts
    {
        public int Id { get; set; }

        public int DepId { get; set; }

        public int SuppplierId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Moblie { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public bool IsDefault { get; set; }
    }
}
