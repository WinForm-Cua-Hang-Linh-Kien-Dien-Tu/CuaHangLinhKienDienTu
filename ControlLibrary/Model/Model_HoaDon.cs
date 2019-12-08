using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Model
{
    public class Model_HoaDon
    {
        public int MaHD { get; set; }

        public int? MaKH { get; set; }

        public int? MaNV { get; set; }

        public string DiaChi { get; set; }

        public int? TongMatHang { get; set; }

        public double? TongTien { get; set; }

        public DateTime? NgayLap { get; set; }

        public DateTime? NgayGiao { get; set; }
    }
}
