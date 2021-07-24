namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThirdCategory")]
    public partial class ThirdCategory
    {
        public int id { get; set; }

        [StringLength(500)]
        public string source { get; set; }

        [StringLength(500)]
        public string categoryName { get; set; }

        [StringLength(500)]
        public string subCategoryName { get; set; }

        public int? typeId { get; set; }

        public DateTime? updateTime { get; set; }
    }
}
