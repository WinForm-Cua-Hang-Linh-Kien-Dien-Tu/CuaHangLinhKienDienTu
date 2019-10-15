using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Model
{
    class ChiTietHoaDonModel
    {
        [DisplayName("Mã Hóa Đơn")]
        public int MaHD { get; set; }

        [DisplayName("Mã Sản Phẩm")]
        public int MaSP { get; set; }

        [DisplayName("Số Lượng")]
        public int? SoLuong { get; set; }

        [DisplayName("Đơn Giá")]
        public decimal? DonGia { get; set; }

        [DisplayName("Thành Tiền")]
        public decimal? ThanhTien { get; set; }

    }
}
