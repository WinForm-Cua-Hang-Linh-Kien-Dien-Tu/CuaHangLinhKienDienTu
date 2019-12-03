using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Model
{
    public class SanPhamModel
    {
        #region Khai Báo Biến
        [DisplayName("Mã Sản Phẩm")]
        public int MaSP { get; set; }

        [DisplayName("Tên Nhà Sản Xuất")]
        public string TenNSX { get; set; }

        [DisplayName("Tên Lọai")]
        public string TenLoai { get; set; }

        [DisplayName("Tên Sản Phẩm")]
        public string TenSP { get; set; }

        [DisplayName("Mô Tả")]
        public string MoTa { get; set; }

        [DisplayName("Giá")]
        public double? Gia { get; set; }

        [DisplayName("Số Lượng")]
        public int? SoLuong { get; set; }

        [DisplayName("Size")]
        public string Size { get; set; }

        [DisplayName("Xuất Xứ")]
        public string XuatXu { get; set; }

        [DisplayName("Đặc Tính")]
        public string DacTinh { get; set; }

        [DisplayName("Hình")]
        public byte[] Hinh2 { get; set; }

        [DisplayName("Tên Hình")]
        public string TenHinh { get; set; }

        [DisplayName("Mã Nhà Sản Xuất")]
        public int? MaNSX { get; set; }

        [DisplayName("Mã Loại")]
        public int? MaLoai { get; set; }
        #endregion

        #region Constructor
        
        public SanPhamModel()
        {
        }
        #endregion
    }
}
