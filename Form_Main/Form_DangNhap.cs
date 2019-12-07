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

        public static string UserName="";

        /// <summary>
        /// Login 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string UserName;
                var item = _quyenDao.GetDVByMa(txt_userName.Text, txt_passWord.Text);
                if (item != null)
                {
                    UserName = txt_userName.Text;
                    Form1 f = new Form1(UserName);
                    
                    f.ShowDialog(this);
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Bạn Nhập Sai UserName Hay PassWord", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Tài Khoản Không Tồn Tái", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
