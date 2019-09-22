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
using DataLibrary.Dao;

namespace ControlLibrary.UC.Display
{
    public partial class UC_SanPham2 : UserControl
    {
        public UC_SanPham2()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            UC_Add_SanPham add_SanPham = new UC_Add_SanPham();
            panel_Container.Dock = DockStyle.Bottom;
            panel_Container.Controls.Add(add_SanPham);
            dataGV_SanPham.Visible = false;
            btn_Back.Visible = true;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UC_Add_SanPham add_SanPham = new UC_Add_SanPham();
            dataGV_SanPham.Visible = true;
            add_SanPham.Visible = false;
            btn_Back.Visible = false;
        }

        private void UC_SanPham2_Load(object sender, EventArgs e)
        {
            var dao = new SanPham();
            dataGV_SanPham.DataSource = dao.loadSanPham();
        }
    }
}
