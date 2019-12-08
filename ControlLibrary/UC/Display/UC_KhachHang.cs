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
using ControlLibrary.Model;
using DataLibrary.EF;

namespace ControlLibrary.UC.Display
{
    public partial class UC_KhachHang : UserControl
    {
        public UC_KhachHang()
        {
            InitializeComponent();
        }
        khachHangDao _khachHangDao = new khachHangDao();
      

        private void UC_KhachHang_Load(object sender, EventArgs e)
        {
            dataGV_KhachHang.DataSource = ListModel(_khachHangDao.GetList());          
        }

        private void btn_Add_KhachHang_Click(object sender, EventArgs e)
        {
            label14.Text = "Thêm thông tin khách hàng";
            txt_TenKH.Text = txt_DiaChi.Text = txt_MatKhau.Text = txt_SDT.Text = txt_SoTK.Text = txt_TaiKhoan.Text = "";
            txt_TenKH.Focus();
            dataGV_KhachHang.Visible = false;
            panel_khachhang.Visible = true;
        }

        private void btn_Edit_KhachHang_Click(object sender, EventArgs e)
        {
            label14.Text = "Cập nhật thông tin khách hàng";
            dataGV_KhachHang.Visible = false;
            panel_khachhang.Visible = true;
        }

        public bool KiemTra_Control_KH()
        {
            if (txt_TenKH.Text != "" && txt_DiaChi.Text != "" && txt_SDT.Text != "")
                return true;
            else
                return false;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            dataGV_KhachHang.Visible = true;
            panel_khachhang.Visible = false;
        }

        public List<Model_KhachHang> ListModel(List<KHACHHANG> ds)
        {
            List<Model_KhachHang> DS_SanPham = new List<Model_KhachHang>();
            foreach (var item in ds)
            {
                Model_KhachHang model = new Model_KhachHang
                {
                    MaKH = item.MaKH,
                    TenKH = item.TenKH,
                    Phai = item.Phai,
                    DiaChi = item.DiaChi,
                    SDT = item.SDT,
                    LoaiKH = item.LoaiKH,
                    SoTaiKhoan = item.SoTaiKhoan,
                    TaiKhoan = item.TaiKhoan,
                    MatKhau = item.MatKhau
                };
                DS_SanPham.Add(model);
            }
            return DS_SanPham;
        }


        private void btn_Remove_KhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                var dao = new KHACHHANG();
                if (dataGV_KhachHang.Rows.Count > 0)
                {
                    int MaKH = Convert.ToInt32(dataGV_KhachHang.SelectedRows[0].Cells[0].Value);
                    int kq = _khachHangDao.Delete(MaKH);
                    if (kq == 1)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        UC_KhachHang_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Xóa Thất Bại");
                }
            }
            catch
            {
                MessageBox.Show("Xóa Thất Bại");
            }
        }

        private void btn_TimKiem_KhachHang_Click(object sender, EventArgs e)
        {
            if (txt_TimKiem_KhachHang.Text != "")
            {
                var ds = _khachHangDao.GetList(txt_TimKiem_KhachHang.Text);

                dataGV_KhachHang.DataSource = ListModel(ds);
            }
        }


        private void btn_CancelKH_Click(object sender, EventArgs e)
        {
            dataGV_KhachHang.Visible = true;
            panel_khachhang.Visible = false;
        }

        private void btn_SaveKH_Click(object sender, EventArgs e)
        {
            string phai;
            if (rdb_Nam.Checked)
                phai = "Nam";
            else
                phai = "Nữ";

            bool kt = KiemTra_Control_KH();
            if (kt == true)
            {
                KHACHHANG kh = new KHACHHANG
                {
                    TenKH = txt_TenKH.Text,
                    Phai = phai,
                    DiaChi = txt_DiaChi.Text,
                    SDT = txt_SDT.Text,
                    LoaiKH = cbb_LoaiKH.Text,
                    SoTaiKhoan = txt_SoTK.Text,
                    TaiKhoan = txt_TaiKhoan.Text,
                    MatKhau = txt_MatKhau.Text,

                };
                if (label14.Text == "Cập nhật thông tin khách hàng")
                {
                    int kq = _khachHangDao.Update(kh, Convert.ToInt32(label_MaSP.Text));
                    if (kq == 1)
                    {
                        MessageBox.Show("Cập Nhật Khách Hàng Thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel_khachhang.Visible = false;
                        dataGV_KhachHang.Visible = true;
                        UC_KhachHang_Load(sender, e);
                    }
                }
                else
                {
                    int kq = _khachHangDao.Add(kh);
                    if (kq == 1)
                    {
                        MessageBox.Show("Thêm Khách Hàng Thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel_khachhang.Visible = false;
                        dataGV_KhachHang.Visible = true;
                        UC_KhachHang_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn Phải Nhập Đủ Các Thuộc Tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_CancelKH_Click_1(object sender, EventArgs e)
        {
            dataGV_KhachHang.Visible = true;
            panel_khachhang.Visible = false;
        }

        private void dataGV_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_MaSP.Text = dataGV_KhachHang.CurrentRow.Cells[0].Value.ToString();
            txt_TenKH.Text = dataGV_KhachHang.CurrentRow.Cells[1].Value.ToString();
            if (dataGV_KhachHang.CurrentRow.Cells[2].Value.ToString() == "Nam")
                rdb_Nam.Checked = true;
            else
                rdb_Nu.Checked = true;
            txt_DiaChi.Text = dataGV_KhachHang.CurrentRow.Cells[3].Value.ToString();
            txt_SDT.Text = dataGV_KhachHang.CurrentRow.Cells[4].Value.ToString();
            txt_SoTK.Text = dataGV_KhachHang.CurrentRow.Cells[6].Value.ToString();
            txt_TaiKhoan.Text = dataGV_KhachHang.CurrentRow.Cells[7].Value.ToString();
            txt_MatKhau.Text = dataGV_KhachHang.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
