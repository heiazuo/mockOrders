namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SurveysFeedBack")]
    public partial class SurveysFeedBack
    {
        public int Id { get; set; }

        [StringLength(3000)]
        public string Opinion { get; set; }

        [Required]
        [StringLength(50)]
        public string Satisfaction { get; set; }

        public int BranchId { get; set; }

        public DateTime AddTime { get; set; }

        public int UserId { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
    }
}
