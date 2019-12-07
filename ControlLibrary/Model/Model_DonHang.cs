using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Model
{
    public class Model_DonHang
    {
        public int ID { get; set; }

        public int? MaKH { get; set; }

        public string TenKH { get; set; }

        public int? MaHD { get; set; }

        public DateTime NgayDat { get; set; }

        public string TrangThai { get; set; }
    }
}
