namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SystemManager")]
    public partial class SystemManager
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string LoginName { get; set; }

        [Required]
        [StringLength(200)]
        public string PassWord { get; set; }

        public DateTime AddTime { get; set; }

        [Required]
        [StringLength(50)]
        public string Role { get; set; }
    }
}
