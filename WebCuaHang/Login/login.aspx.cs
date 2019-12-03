
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
    public partial class login : System.Web.UI.Page
    {
        khachHangDao khDao = new khachHangDao();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string username = txt_email.Text;
            string password = txt_password.Text;
            //byte[] pass = Encoding.ASCII.GetBytes(password);
            var kq = khDao.Login_KH(username, password);
            if (kq != null)
            {
                Session["User"] = kq.MaKH;
                Response.Redirect("~/WebDisplaySanPham.aspx");
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Đăng nhập không thành công')", true);
            }
        }
    }
}