using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary.Dao;

namespace ControlLibrary.UC.Display
{
    public partial class UC_KhachHang : UserControl
    {
        public UC_KhachHang()
        {
            InitializeComponent();
        }
        khachHangDao _khachHangDao = new khachHangDao();
        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void UC_KhachHang_Load(object sender, EventArgs e)
        {
            dataGV_KhachHang.DataSource = _khachHangDao.GetList();
        }
    }
}
