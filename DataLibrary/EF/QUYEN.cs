namespace DataLibrary.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUYEN")]
    public partial class QUYEN
    {
        public int ID { get; set; }

        public int? MaNV { get; set; }

        [StringLength(12)]
        public string User { get; set; }

        [StringLength(20)]
        public string PassWord { get; set; }

        [Column("Quyen")]
        [StringLength(20)]
        public string Quyen1 { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
