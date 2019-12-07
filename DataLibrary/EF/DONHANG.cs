namespace DataLibrary.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONHANG")]
    public partial class DONHANG
    {
        public int ID { get; set; }

        public int? MaKH { get; set; }

        public int? MaHD { get; set; }

        [StringLength(100)]
        public string TrangThai { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }
    }
}
