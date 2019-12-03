using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLibrary.Dao;
using DataLibrary.EF;
using DataLibrary.Model;

namespace WebCuaHang
{
    public partial class WebDisplaySanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        } 
       
        public List<DataLibrary.EF.SANPHAM> SanPhamList_GetData1()
        {
            SanPham sp = new SanPham();
            return sp.GetList();
        }
    }
}