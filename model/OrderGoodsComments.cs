namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderGoodsComments
    {
        public int Id { get; set; }

        public int GoodsId { get; set; }

        public int OrderDetailId { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public int MemberId { get; set; }

        public int Score { get; set; }

        [Required]
        [StringLength(500)]
        public string CommentContent { get; set; }

        public int Recommend { get; set; }

        public bool IsAnonymous { get; set; }

        public DateTime AddTime { get; set; }

        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(500)]
        public string Label { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
