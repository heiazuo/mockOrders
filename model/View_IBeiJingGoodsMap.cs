namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_IBeiJingGoodsMap
    {
        [StringLength(255)]
        public string Expr1 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(255)]
        public string I_ProductId { get; set; }

        [StringLength(255)]
        public string I_Category { get; set; }

        [StringLength(255)]
        public string I_Brand { get; set; }

        [StringLength(500)]
        public string I_ProductName { get; set; }

        public decimal? I_SalePrice { get; set; }

        public int? DonvvGoodsId { get; set; }

        public DateTime? UpdateTime { get; set; }

        public int? BranchId { get; set; }
    }
}
