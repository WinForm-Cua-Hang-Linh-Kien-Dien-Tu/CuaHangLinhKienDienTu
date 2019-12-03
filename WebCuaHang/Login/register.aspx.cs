
using DataLibrary.Dao;
using DataLibrary.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SpaWeb.User.Login
{
    public partial class register : System.Web.UI.Page
    {
        khachHangDao khDao = new khachHangDao();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_dangky_Click(object sender, EventArgs e)
        {
            //byte[] pass = Encoding.ASCII.GetBytes(txt_password.Text);
            KHACHHANG kh = new KHACHHANG();
            kh.TenKH = txt_name.Text;
            kh.TaiKhoan = txt_username.Text;
            kh.MatKhau = txt_password.Text;
            kh.SDT = txt_phone.Text;
            kh.DiaChi = txt_name.Text;
            
            var kq = khDao.Add(kh);
            if (kq == 1)
            {
                lbResult.Visible = true;
                lbResult.Text = "Đăng ký không thành công";
            }
            else
            {
                lbResult.Visible = true;
                lbResult.Text = "Đăng ký không thành công";
            }
        }
    }
}