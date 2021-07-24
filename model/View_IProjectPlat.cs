namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_IProjectPlat
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int I_PlatId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BranchId { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string AppKey { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string AppSecret { get; set; }

        [StringLength(100)]
        public string AccessToken { get; set; }

        public DateTime? ExpirationDate { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime UpdateTime { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string PlatName { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int I_ProviderId { get; set; }

        [StringLength(50)]
        public string PlatMemo { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string ProviderName { get; set; }

        [StringLength(50)]
        public string ProviderMemo { get; set; }

        public bool? IsPostData { get; set; }

        [StringLength(5000)]
        public string PrivateKey { get; set; }

        [StringLength(100)]
        public string client_id { get; set; }
    }
}
