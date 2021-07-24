namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_CarUser
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public int UserId { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
