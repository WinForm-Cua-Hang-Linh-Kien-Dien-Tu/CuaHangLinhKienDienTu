using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Model
{
    public class Model_SanPham
    {
        #region Khai Báo Biến
        public int MaSP { get; set; }

        public string TenNSX { get; set; }

        public string TenLoai { get; set; }

        public string TenSP { get; set; }

        public double? Gia { get; set; }

        public int? SoLuong { get; set; }

        public string Size { get; set; }

        public string XuatXu { get; set; }

        public string DacTinh { get; set; }

        #endregion
    }
}
