namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StrategyRule")]
    public partial class StrategyRule
    {
        public int Id { get; set; }

        public int StrategyId { get; set; }

        public int Mode { get; set; }

        public decimal? RangeAmount { get; set; }

        public decimal? MaxAmount { get; set; }

        public decimal? MinAmount { get; set; }

        public decimal? TargetAmount { get; set; }

        public int? Extend1 { get; set; }

        public decimal? Extend2 { get; set; }

        [StringLength(200)]
        public string Extend3 { get; set; }

        public int Category { get; set; }
    }
}
