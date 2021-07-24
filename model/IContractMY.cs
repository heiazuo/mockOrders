namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IContractMY")]
    public partial class IContractMY
    {
        public int Id { get; set; }

        public int IProjectId { get; set; }

        public int BranchId { get; set; }

        public int orderId { get; set; }

        [Required]
        [StringLength(50)]
        public string fileName { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string fileByte { get; set; }

        [Column(TypeName = "text")]
        public string fileByted { get; set; }

        public bool IsSigned { get; set; }

        [StringLength(255)]
        public string fielUrl { get; set; }

        public DateTime dtSubmitTime { get; set; }

        public DateTime? dtSignTime { get; set; }
    }
}
