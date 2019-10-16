using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Model
{
    class LoaiModel
    {
        [DisplayName("Mã Hóa Đơn")]
        public int MaLoai { get; set; }

        [DisplayName("Mã Hóa Đơn")]
        public string TenLoai { get; set; }
    }
}
