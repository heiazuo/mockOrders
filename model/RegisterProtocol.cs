namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RegisterProtocol")]
    public partial class RegisterProtocol
    {
        public int Id { get; set; }

        [Required]
        public string ProtocolContent { get; set; }

        public int UserId { get; set; }

        public DateTime AddTime { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string ProtocolName { get; set; }
    }
}
