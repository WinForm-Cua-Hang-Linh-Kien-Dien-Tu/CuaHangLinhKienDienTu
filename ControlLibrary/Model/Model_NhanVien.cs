using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Model
{
    public class Model_NhanVien
    {
        [DisplayName("Mã Nhân Viên")]
        public int MaNV { get; set; }

        [DisplayName("Tên Nhân Viên")]
        public string TenNV { get; set; }

        [DisplayName("Ngày Sinh")]
        public DateTime? NgaySinh { get; set; }

        [DisplayName("Giới Tính")]
        public string GioiTinh { get; set; }

        [DisplayName("Địa Chỉ")]
        public string DiaChi { get; set; }

        [DisplayName("Số Điện Thoại")]
        public string SDT { get; set; }

        [DisplayName("Chức Vụ")]
        public string ChucVu { get; set; }


       
    }
}
