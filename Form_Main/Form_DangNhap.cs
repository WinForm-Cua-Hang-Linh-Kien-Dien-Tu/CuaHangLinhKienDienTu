using DataLibrary.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Main
{
    public partial class Form_DangNhap : Form
    {
        public Form_DangNhap()
        {
            InitializeComponent();
        }
        quyenDao _quyenDao = new quyenDao();

        public string UserName
        {
            get { return txt_userName.Text; }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var item = _quyenDao.GetDVByMa(txt_userName.Text, txt_passWord.Text);
            if(item != null)
            {
                Form1 f = new Form1();
                f.Show();
                this.Visible = false;
            }
        }
    }
}
