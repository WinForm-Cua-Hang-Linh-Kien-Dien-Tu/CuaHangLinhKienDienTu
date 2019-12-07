using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ControlLibrary.Model;
using DataLibrary.Dao;
using DataLibrary.EF;

namespace WebCuaHang
{
    public partial class GioHang : System.Web.UI.Page
    {
        SanPham sanPham = new SanPham();
        hoaDonDao hdDao = new hoaDonDao();
        chiTietHoaDonDao chiTietHoaDonDao = new chiTietHoaDonDao();
        donHangDao _donHangDao = new donHangDao();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cart"] == null)
            {
                lb_notify.Text = "Giỏ Hàng Trống";
                lb_notify.Visible = true;
                btn_datHang.Visible = false;
            }
            else
            {
                btn_datHang.Visible = true;
                double tong = 0;
                List<Model_CartItem> list = (List<Model_CartItem>)Session["cart"];
                foreach (var i in list)
                {
                    SANPHAM sp = sanPham.GetDVByMa(i.MA_SP);
                    tong += sp.Gia.GetValueOrDefault() * i.SoLuong;
                }
                lb_tongtien.Visible = true;
                lb_tongtien.Text = tong.ToString();
                lb_title.Visible = true;
            }
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public List<Model_CartItem> CartItemGridView_GetData()
        {
            if (Session["cart"] != null)
            {
                List<Model_CartItem> list = (List<Model_CartItem>)Session["cart"];
                foreach (var i in list)
                {
                    SANPHAM sp = sanPham.GetDVByMa(i.MA_SP);
                    i.TEN_SP = sp.TenSP;
                    i.DON_GIA = sp.Gia.GetValueOrDefault();
                    i.THANH_TIEN = i.SoLuong * i.DON_GIA;
                }
                return list;
            }
            return null;
        }

        protected void btn_xoaCartItem_Click(object sender, EventArgs e)
        {
            List<Model_CartItem> list = (List<Model_CartItem>)Session["cart"];
            lb_notify.Visible = true;
            if (CartItemGridView.Rows.Count > 0)
            {
                var btn = (Control)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;
                int cartID = Convert.ToInt32(row.Cells[0].Text);
              
                Model_CartItem c = new Model_CartItem();
                foreach (var i in list)
                {
                    if (i.MA_SP == cartID)
                    {
                        c = i;
                        break;
                    }
                }
                list.Remove(c);
                if (list.Count == 0)
                {
                    Session.Remove("cart");
                }

                Page.Response.Redirect(Page.Request.Url.ToString(), true);
            }
        }

        protected void btn_datHang_Click(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("~/Login/login.aspx");
            }
            else
            {
                HOADON hd = new HOADON();
                DONHANG donHang = new DONHANG();
                int maKH = Convert.ToInt32(Session["User"]); ;
                hd.MaKH = maKH;

                if (hdDao.Add(hd) == 1)
                {
                    double tongtien = 0;
                    if (CartItemGridView.Rows.Count > 0)
                    {
                        foreach (GridViewRow row in CartItemGridView.Rows)
                        {
                            CHITIETHOADON ct = new CHITIETHOADON();
                            SANPHAM sp = new SANPHAM();

                            ct.MaHD = hd.MaHD;
                            ct.MaSP = Convert.ToInt32(row.Cells[0].Text);
                            TextBox sl = (TextBox)row.FindControl("txt_SoLuong");
                            ct.SoLuong = Convert.ToInt32(sl.Text);
                            Label giastr = (Label)row.FindControl("txt_gia");
                            double gia = Convert.ToDouble(giastr.Text);
                            ct.ThanhTien = Convert.ToDouble(ct.SoLuong * gia);
                            chiTietHoaDonDao.Add(ct);
                            tongtien += ct.ThanhTien.GetValueOrDefault();

                            // Cập Nhật Lại Số Lượng Sản Phẩm
                            sp.MaSP = Convert.ToInt32(row.Cells[0].Text); // Gán giá trị cho MaSP

                            // SoLuong = số Lượng Hiện Tại - Số Lượng Bán
                            sp.SoLuong = sanPham.GetDVByMa(Convert.ToInt32(row.Cells[0].Text)).SoLuong - Convert.ToInt32(sl.Text);
                            sanPham.UpdateSoLuong(sp);
                        }

                    }
                    hd.TongTien = tongtien;
                    hdDao.Update(hd);
                    //Thêm Hóa Đơn
                    hdDao.Update(hd);

                    // Thêm đơn hàng
                    donHang.MaHD = hd.MaHD;
                    donHang.MaKH = maKH;
                    donHang.TrangThai = "Chưa Xác Nhận";
                    donHang.NgayDat = DateTime.Now;
                    _donHangDao.Add(donHang);

                    Session.Remove("cart");

                   
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Đặt Hàng thành công')", true);
                }
                else
                {
                    Page.ClientScript.RegisterClientScriptBlock(typeof(Page), "Alert", "alert('Đặt Hàng không thành công')", true);
                }

            }

            Page.Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
    
}