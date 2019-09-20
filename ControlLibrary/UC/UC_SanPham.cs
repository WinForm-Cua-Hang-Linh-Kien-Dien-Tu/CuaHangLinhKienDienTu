using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlLibrary.UC.Add_Edit;

namespace ControlLibrary.UC
{
    public partial class UC_SanPham : UserControl
    {
        public UC_SanPham()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            UC_Add_SanPham add_SanPham = new UC_Add_SanPham();
            panel_Container.Dock = DockStyle.Bottom;
            panel_Container.Controls.Add(add_SanPham);
            dataGV_SanPham.Visible = false;
        }
    }
}
