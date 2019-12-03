using DataLibrary.Dao;
using DataLibrary.EF;
using DataLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCuaHang
{
    public partial class SanPhamDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The id parameter should match the DataKeyNames value set on the control
        // or be decorated with a value provider attribute, e.g. [QueryString]int id
        public SANPHAM sanPhamDetail_GetItem([QueryString("MaSP")] int id)
        {
            SanPham sp = new SanPham();
            var result = sp.GetID(id);
            return result;
        }

        protected void btn_AddCart_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["MaSP"]);
            TextBox t = (TextBox)sanPhamDetail.Row.FindControl("txt_soLuong");
            if (Session["cart"] == null)
            {
                List<CartModel> listcart = new List<CartModel>();
                CartModel cart = new CartModel();
                cart.CartID = 0;
                cart.MA_SP = id;
                cart.SoLuong = Convert.ToInt32(t.Text);
                listcart.Add(cart);
                Session["cart"] = listcart;
                
            }
            else
            {
                bool check = true;
                List<CartModel> list = (List<CartModel>)Session["cart"];
                int lenght = list.Count;
                foreach(var i in list){
                    if(i.MA_SP == id)
                    {
                        i.SoLuong += Convert.ToInt32(t.Text);
                        check = false;
                    }
                }
                if (check)
                {
                    CartModel cart = new CartModel();
                    cart.CartID = lenght;
                    cart.MA_SP = id;
                    cart.SoLuong = Convert.ToInt32(t.Text);
                    list.Add(cart);
                }
                Session["cart"] = list;
                
            }

            //Response.Redirect("GioHang.aspx");
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}