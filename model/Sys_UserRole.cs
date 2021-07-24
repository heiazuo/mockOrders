namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_UserRole
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int RoleId { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
