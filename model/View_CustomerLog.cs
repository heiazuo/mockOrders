namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_CustomerLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Type { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "text")]
        public string Content { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime UpdateTime { get; set; }

        [StringLength(200)]
        public string CustomerName { get; set; }

        [StringLength(50)]
        public string MemberName { get; set; }

        [StringLength(50)]
        public string Telphone { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }
    }
}
