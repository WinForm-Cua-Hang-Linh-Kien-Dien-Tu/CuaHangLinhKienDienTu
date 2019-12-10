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
    public partial class Form1 : Form
    {
        string UserName = "";
        quyenDao _quyenDao = new quyenDao();

        public Form1(string UserName)
        {
            InitializeComponent();
            pn_Chuyen.Height = btn_SanPham.Height;
            pn_Chuyen.Top = btn_SanPham.Top;
            uC_SanPham21.BringToFront();
            label1.Text = UserName;
            this.UserName = UserName;
        }

        /// <summary>
        /// Phần Quyền User
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            var item = _quyenDao.GetDVByMa(UserName);
            if(item != null)
            {
                if(item.Quyen1 == "Nhân Viên")
                {
                    btn_Quyen.Visible = false;
                    btn_ThongKe.Visible = false;
                    btn_NhanVien.Visible = false;
                }
                else
                {
                    if(item.Quyen1 == "")
                    {
                        btn_Quyen.Visible = false;
                        btn_ThongKe.Visible = false;
                        btn_NhanVien.Visible = false;
                        btn_KhachHang.Visible = false;
                        btn_HoaDon.Visible = false;
                        btn_DonHang.Visible = false;
                        btn_SanPham.Visible = false;
                        uC_UserProfile1.BringToFront();
                    }
                }
            }
        }

        #region Chuyển UserControl

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            pn_Chuyen.Height = btn_SanPham.Height;
            pn_Chuyen.Top = btn_SanPham.Top;
            uC_SanPham21.BringToFront();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            pn_Chuyen.Height = btn_HoaDon.Height;
            pn_Chuyen.Top = btn_HoaDon.Top;
            uC_HoaDon1.BringToFront();
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            pn_Chuyen.Height = btn_KhachHang.Height;
            pn_Chuyen.Top = btn_KhachHang.Top;
            uC_KhachHang1.BringToFront();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            pn_Chuyen.Height = btn_NhanVien.Height;
            pn_Chuyen.Top = btn_NhanVien.Top;
            uC_NhanVien1.BringToFront();
        }

        private void btn_Quyen_Click(object sender, EventArgs e)
        {
            pn_Chuyen.Height = btn_Quyen.Height;
            pn_Chuyen.Top = btn_Quyen.Top;
            uC_Quyen1.BringToFront();
        }


        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            pn_Chuyen.Height = btn_ThongKe.Height;
            pn_Chuyen.Top = btn_ThongKe.Top;
            uC_UserProfile1.BringToFront();
        }

        private void btn_DonHang_Click(object sender, EventArgs e)
        {
            pn_Chuyen.Height = btn_DonHang.Height;
            pn_Chuyen.Top = btn_DonHang.Top;
            uC_DonHang1.BringToFront();
        }

       
        #endregion

        #region Chức Năng Button trên góc phải
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            Form_DangNhap dangNhap = new Form_DangNhap();
            dangNhap.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        
    }
}
