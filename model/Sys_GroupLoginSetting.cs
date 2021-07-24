namespace ErpDataFactory
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_GroupLoginSetting
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        [Required]
        [StringLength(50)]
        public string body_bg_color { get; set; }

        public int wrapper_width { get; set; }

        public int wrapper_minheight { get; set; }

        [Required]
        [StringLength(50)]
        public string wrapper_bg_color { get; set; }

        [Required]
        [StringLength(300)]
        public string wrapper_bg_img { get; set; }

        public int header_height { get; set; }

        [Required]
        [StringLength(300)]
        public string header_logo_img { get; set; }

        public int login_height { get; set; }

        [Required]
        [StringLength(50)]
        public string login_bg_img { get; set; }

        public int login_box_top { get; set; }

        public int login_box_right { get; set; }

        public int footer_height { get; set; }

        [Required]
        [StringLength(50)]
        public string footer_bg_color { get; set; }

        [Required]
        [StringLength(50)]
        public string footer_color { get; set; }

        public DateTime updatetime { get; set; }

        [Required]
        [StringLength(50)]
        public string header_bg_color { get; set; }

        [Required]
        [StringLength(300)]
        public string header_bg_img { get; set; }

        [Required]
        [StringLength(50)]
        public string login_box_bg_color { get; set; }

        public int login_box_radius { get; set; }
    }
}
