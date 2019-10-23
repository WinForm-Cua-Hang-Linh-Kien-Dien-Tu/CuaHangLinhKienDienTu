using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Model
{
    class NhaSanXuatModel
    {
        [DisplayName("Mã Nhà Sản Xuất")]
        public int MaNSX { get; set; }

        [DisplayName("Tên Nhà Sản Xuất")]
        public string TenNSX { get; set; }
    }
}
