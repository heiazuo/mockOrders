namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoginedIdentity")]
    public partial class LoginedIdentity
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        [Required]
        [StringLength(500)]
        public string BuyerCookie { get; set; }

        [Required]
        [StringLength(500)]
        public string SessionId { get; set; }

        public DateTime? CreatedAt { get; set; }

        [Column(TypeName = "text")]
        public string PostUrl { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string UserEmail { get; set; }
    }
}
