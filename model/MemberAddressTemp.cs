namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MemberAddressTemp")]
    public partial class MemberAddressTemp
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        [Required]
        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(20)]
        public string Province { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        public string Area { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string TelPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public bool IsDefault { get; set; }

        public bool IsDelete { get; set; }
    }
}
