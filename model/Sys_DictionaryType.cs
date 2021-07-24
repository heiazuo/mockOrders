namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_DictionaryType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_DictionaryType()
        {
            Sys_Dictionary = new HashSet<Sys_Dictionary>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public int Sort { get; set; }

        public bool IsDelete { get; set; }

        public int BranchId { get; set; }

        public bool IsSystem { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateUser { get; set; }

        public DateTime CreateTime { get; set; }

        [Required]
        [StringLength(50)]
        public string UpdateUser { get; set; }

        public DateTime UpdateTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Dictionary> Sys_Dictionary { get; set; }
    }
}
