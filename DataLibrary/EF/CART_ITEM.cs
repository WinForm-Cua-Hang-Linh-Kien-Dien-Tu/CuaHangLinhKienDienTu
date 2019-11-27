namespace DataLibrary.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CART_ITEM
    {
        [Key]
        public int CartID { get; set; }

        public int? MA_KH { get; set; }

        public int? SoLuong { get; set; }

        public DateTime? NgayTao { get; set; }

        public int? MA_SP { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
