namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_City
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string PCode { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? level { get; set; }

        public DateTime createTime { get; set; }
    }
}
