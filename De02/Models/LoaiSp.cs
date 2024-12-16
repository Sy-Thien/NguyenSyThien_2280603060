namespace De02.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiSp")]
    public partial class LoaiSp
    {
        [Key]
        [StringLength(2)]
        public string MaLoai { get; set; }

        [Required]
        [StringLength(30)]
        public string TenLoai { get; set; }
    }
}
