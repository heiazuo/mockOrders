namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Dictionary
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string EnglishName { get; set; }

        public int ParentId { get; set; }

        public int Sort { get; set; }

        public bool IsEnable { get; set; }

        public bool IsDefault { get; set; }

        public bool IsDelete { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public int TypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string TypeName { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateName { get; set; }

        public DateTime CreateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string UpdateUser { get; set; }

        public DateTime UpdateTime { get; set; }

        public virtual Sys_DictionaryType Sys_DictionaryType { get; set; }
    }
}
