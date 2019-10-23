using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Model
{
    class HoaDonModel
    {
        [DisplayName("Mã Hóa Đơn")]
        public int MaHD { get; set; }

        [DisplayName("ID")]
        public int ID { get; set; }

        [DisplayName("Địa Chỉ")]
        public string DiaChi { get; set; }

        [DisplayName("Tổng Mặt Hàng")]
        public int? TongMatHang { get; set; }

        [DisplayName("Tổng Tiền")]
        public decimal? TongTien { get; set; }

        [DisplayName("Ngày Lập")]
        public DateTime? NgayLap { get; set; }

        [DisplayName("Ngày Giao")]
        public DateTime? NgayGiao { get; set; }
    }
}
