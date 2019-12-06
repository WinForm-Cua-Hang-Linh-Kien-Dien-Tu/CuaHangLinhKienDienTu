using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary.Model
{
    public class Model_CartItem
    {
        public int CartID { get; set; }

        public int MA_KH { get; set; }

        public string TEN_SP { get; set; }

        public int SoLuong { get; set; }

        public double DON_GIA { get; set; }

        public DateTime NgayTao { get; set; }

        public int MA_SP { get; set; }

        public double THANH_TIEN { get; set; }
    }
}
