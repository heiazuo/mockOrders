namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CanvassAgreement")]
    public partial class CanvassAgreement
    {
        public int Id { get; set; }

        [Required]
        public string AgreementContent { get; set; }

        public int UserId { get; set; }

        public DateTime AddTime { get; set; }

        public int BranchId { get; set; }
    }
}
