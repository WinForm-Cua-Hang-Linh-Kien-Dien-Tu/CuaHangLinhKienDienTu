using DataLibrary.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Model
{
    public class Model_ChiTietHoaDon
    {
        public int ID { get; set; }

        public int MaHD { get; set; }

        public int MaSP { get; set; }

        public int? SoLuong { get; set; }

        public double? DonGia { get; set; }

        public double? ThanhTien { get; set; }

        public virtual HOADON HOADON { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
