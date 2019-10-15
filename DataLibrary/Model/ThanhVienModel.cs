using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Model
{
    class ThanhVienModel
    {
        [DisplayName("Mã Nhân Viên")]
        public int ID { get; set; }

        [DisplayName("Tài Khoản")]
        public string TaiKhoan { get; set; }

        [DisplayName("Mật Khẩu")]
        public string MatKhau { get; set; }

        [DisplayName("Tên Tài Khoản")]
        public string TenKH { get; set; }

        [DisplayName("Địa Chỉ")]
        public string DiaChi { get; set; }

        [DisplayName("Giới Tính")]
        public string GioiTinh { get; set; }

        [DisplayName("Số Điện Thoại")]
        public string SDT { get; set; }

        [DisplayName("Ngày Sinh")]
        public DateTime? NgaySinh { get; set; }
    }
}
