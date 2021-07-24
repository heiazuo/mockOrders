namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_ProjectExtention
    {
        public int Id { get; set; }

        public int I_ProjectId { get; set; }

        [Required]
        [StringLength(100)]
        public string PropName { get; set; }

        [Required]
        [StringLength(500)]
        public string PropValue { get; set; }
    }
}
