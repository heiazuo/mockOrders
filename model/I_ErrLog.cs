namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_ErrLog
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string ErrorMessage { get; set; }

        [Required]
        [StringLength(500)]
        public string JsonStr { get; set; }

        [Required]
        [StringLength(50)]
        public string ControllerName { get; set; }

        [Required]
        [StringLength(50)]
        public string ActionName { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
