namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_DeadLock_Process
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short spid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short kpid { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short blocked { get; set; }

        [Key]
        [Column(Order = 3)]
        [MaxLength(2)]
        public byte[] waittype { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long waittime { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(32)]
        public string lastwaittype { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(256)]
        public string waitresource { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short dbid { get; set; }

        public short? uid { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cpu { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long physical_io { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int memusage { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime login_time { get; set; }

        [Key]
        [Column(Order = 12)]
        public DateTime last_batch { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short ecid { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short open_tran { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(30)]
        public string status { get; set; }

        [Key]
        [Column(Order = 16)]
        [MaxLength(86)]
        public byte[] sid { get; set; }

        [Key]
        [Column(Order = 17)]
        public string hostname { get; set; }

        [Key]
        [Column(Order = 18)]
        public string program_name { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(10)]
        public string hostprocess { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(16)]
        public string cmd { get; set; }

        [Key]
        [Column(Order = 21)]
        public string nt_domain { get; set; }

        [Key]
        [Column(Order = 22)]
        public string nt_username { get; set; }

        [Key]
        [Column(Order = 23)]
        [StringLength(12)]
        public string net_address { get; set; }

        [Key]
        [Column(Order = 24)]
        [StringLength(12)]
        public string net_library { get; set; }

        [Key]
        [Column(Order = 25)]
        public string loginame { get; set; }

        [Key]
        [Column(Order = 26)]
        public byte[] context_info { get; set; }

        [Key]
        [Column(Order = 27)]
        [MaxLength(20)]
        public byte[] sql_handle { get; set; }

        [Key]
        [Column(Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int stmt_start { get; set; }

        [Key]
        [Column(Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int stmt_end { get; set; }

        [Key]
        [Column(Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int request_id { get; set; }
    }
}
