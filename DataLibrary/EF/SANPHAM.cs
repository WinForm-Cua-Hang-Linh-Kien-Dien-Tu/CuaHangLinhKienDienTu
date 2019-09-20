namespace DataLibrary.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CHITIETHOADON = new HashSet<CHITIETHOADON>();
        }

        [Key]
        public int MaSP { get; set; }

        public int? MaNSX { get; set; }

        public int? MaLoai { get; set; }

        [StringLength(100)]
        public string TenSP { get; set; }

        [StringLength(500)]
        public string MoTa { get; set; }

        [Column(TypeName = "money")]
        public decimal? Gia { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(100)]
        public string Size { get; set; }

        [StringLength(30)]
        public string XuatXu { get; set; }

        [StringLength(500)]
        public string DacTinh { get; set; }

        [StringLength(100)]
        public string Hinh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADON { get; set; }

        public virtual LOAI LOAI { get; set; }

        public virtual NHASANXUAT NHASANXUAT { get; set; }
    }
}
