using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Model
{
    public class Model_KhachHang
    {
        [DisplayName("Mã Khách Hàng")]
        public int MaKH { get; set; }

        [DisplayName("Tên Khách Hàng")]
        public string TenKH { get; set; }

        [DisplayName("Phái")]
        public string Phai { get; set; }

        [DisplayName("Địa chỉ")]
        public string DiaChi { get; set; }

        [DisplayName("Số điện thoại")]
        public string SDT { get; set; }

        [DisplayName("Loại khách hàng")]
        public string LoaiKH { get; set; }

        [DisplayName("Số tài khoản")]
        public string SoTaiKhoan { get; set; }

        [DisplayName("Tài khoản")]
        public string TaiKhoan { get; set; }

        [DisplayName("Mật khẩu")]
        public string MatKhau { get; set; }
    }
}
