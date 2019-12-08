using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary.UC.Display
{
    public partial class UC_HoaDon : UserControl
    {
        public UC_HoaDon()
        {
            InitializeComponent();
        }

        private void txt_TimKiemHoaDon_Click(object sender, EventArgs e)
        {
            txt_TimKiemHoaDon.Text = "";
        }
    }
}
