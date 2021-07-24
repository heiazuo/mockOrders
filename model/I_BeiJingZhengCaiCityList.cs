namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class I_BeiJingZhengCaiCityList
    {
        public int Id { get; set; }

        [StringLength(255)]
        public string Code { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Parent { get; set; }

        [StringLength(255)]
        public string type { get; set; }

        [StringLength(255)]
        public string Memo { get; set; }
    }
}
