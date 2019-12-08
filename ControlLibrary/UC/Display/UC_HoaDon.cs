﻿using System;
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
    public partial class UC_HoaDon : UserControl
    {
        public UC_HoaDon()
        {
            InitializeComponent();
        }

        hoaDonDao _hoaDonDao = new hoaDonDao();
        chiTietHoaDonDao _chiTietHoaDonDao = new chiTietHoaDonDao();
        SanPham _sanPham = new SanPham();
        khachHangDao _khachHangDao = new khachHangDao();

        public List<Model_HoaDon> ListModel_HD(List<HOADON> ds)
        {
            List<Model_HoaDon> DS_HoaDon = new List<Model_HoaDon>();
            foreach (var item in ds)
            {
                Model_HoaDon model = new Model_HoaDon
                {
                    MaHD = item.MaHD,
                    MaKH = item.MaKH,
                    MaNV = item.MaNV,
                    DiaChi = item.DiaChi,
                    TongMatHang = item.TongMatHang,
                    TongTien = item.TongTien,
                    NgayLap = item.NgayLap,
                    NgayGiao = item.NgayGiao
                };
                DS_HoaDon.Add(model);
            }
            return DS_HoaDon;
        }

        public List<Model_ChiTietHoaDon> ListModel_CTHD(List<CHITIETHOADON> ds)
        {
            List<Model_ChiTietHoaDon> DS_CTHD = new List<Model_ChiTietHoaDon>();
            foreach (var item in ds)
            {
                Model_ChiTietHoaDon model = new Model_ChiTietHoaDon
                {
                    ID = item.ID,
                    MaHD = item.MaHD,
                    MaSP = item.MaSP,
                    SoLuong = item.SoLuong,
                    DonGia = item.DonGia,
                    ThanhTien = item.ThanhTien
                };
                DS_CTHD.Add(model);
            }
            return DS_CTHD;
        }

        private void UC_HoaDon_Load(object sender, EventArgs e)
        {
            dataGV_HoaDon.DataSource = ListModel_HD(_hoaDonDao.GetList());
            cbb_TenSP.DataSource = _sanPham.GetDSTen();
        }

        private void btn_Add_HoaDon_Click(object sender, EventArgs e)
        {
            panel_themhoadon.Visible = true;
            panel_dshoadon.Visible = false;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            panel_themhoadon.Visible = false;
            panel_dshoadon.Visible = true;
        }

        private void cbb_TenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ten = cbb_TenSP.SelectedItem.ToString();
            double gia = _sanPham.GetGiaSP(ten);
            txt_DonGia.Text = gia.ToString();
        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_SoLuong_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_SoLuong.Text))
                txt_ThanhTien.Text = "";
            else
            {
                double gia = Convert.ToDouble(txt_DonGia.Text) * Convert.ToDouble(txt_SoLuong.Text);
                txt_ThanhTien.Text = gia.ToString();
            }
        }

        private void txt_DonGia_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_SoLuong.Text))
                txt_ThanhTien.Text = "";
            else
            {
                double gia = Convert.ToDouble(txt_DonGia.Text) * Convert.ToDouble(txt_SoLuong.Text);
                txt_ThanhTien.Text = gia.ToString();
            }
        }

        private void btn_CancelHD_Click(object sender, EventArgs e)
        {
            panel_themhoadon.Visible = false;
            panel_dshoadon.Visible = true;
        }

        public bool KiemTra_ControlHD()
        {
            if (!string.IsNullOrEmpty(txt_SDT.Text) && !string.IsNullOrEmpty(txt_SoLuong.Text) && !string.IsNullOrEmpty(txt_ThanhTien.Text))
                return true;
            else
                return false;
        }

        private void btn_SaveHD_Click(object sender, EventArgs e)
        {
            string tensp = cbb_TenSP.SelectedItem.ToString();
            DateTime today = DateTime.Today;
            string sdt = txt_SDT.Text;
            int ma = _khachHangDao.GetMaKH(sdt);
            int masp = _sanPham.GetMaSP(tensp);
            bool kt = KiemTra_ControlHD();
            if (kt == true)
            {
                HOADON hd = new HOADON
                {
                    MaKH = ma,
                    TongTien = Convert.ToDouble(txt_ThanhTien.Text),
                    NgayLap = today
                };
                

                int kq = _hoaDonDao.Add(hd);

                dataGV_HoaDon.DataSource = ListModel_HD(_hoaDonDao.GetList());

                CHITIETHOADON cthd = new CHITIETHOADON
                {
                    MaHD = Convert.ToInt32(dataGV_HoaDon.Rows[dataGV_HoaDon.Rows.Count - 1].Cells[0].Value.ToString()),
                    MaSP = masp,
                    SoLuong = Convert.ToInt32(txt_SoLuong.Text),
                    DonGia = Convert.ToInt32(txt_DonGia.Text),
                    ThanhTien = Convert.ToInt32(txt_ThanhTien.Text)
                };
                int kq_cthd = _chiTietHoaDonDao.Add(cthd);
                if (kq == 1 && kq_cthd == 1)
                {
                    MessageBox.Show("Thêm Hóa đơn Thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel_themhoadon.Visible = false;
                    panel_dshoadon.Visible = true;
                    dataGV_HoaDon.Visible = true;
                    UC_HoaDon_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Bạn Phải Nhập Đủ Các Thuộc Tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Remove_HoaDon_Click(object sender, EventArgs e)
        {          
            try
            {
                var dao = new hoaDonDao();
                var dao_cthd = new chiTietHoaDonDao();
                if (dataGV_HoaDon.Rows.Count > 0)
                {
                    int MaHD = Convert.ToInt32(dataGV_HoaDon.SelectedRows[0].Cells[0].Value);
                    int MaSP = Convert.ToInt32(dataGV_CTHD.SelectedRows[0].Cells[2].Value);
                    int kq_cthd = _chiTietHoaDonDao.Delete(MaHD, MaSP);
                    int kq = _hoaDonDao.Delete(MaHD);
                    if (kq == 1)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        UC_HoaDon_Load(sender, e);
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

        private void dataGV_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ma = Convert.ToInt32(dataGV_HoaDon.CurrentRow.Cells[0].Value.ToString());
            dataGV_CTHD.DataSource = ListModel_CTHD(_chiTietHoaDonDao.GetList(ma));
        }
    }
}
