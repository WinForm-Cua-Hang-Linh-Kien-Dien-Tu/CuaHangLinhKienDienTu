using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlLibrary.Model;
using DataLibrary.Dao;
using DataLibrary.EF;

namespace ControlLibrary.UC.Display
{
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
        }

        nhanVienDao _nhanVienDao = new nhanVienDao();
        quyenDao _quyenDao = new quyenDao();

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            var ds = _nhanVienDao.GetList();

            dataGV_NhanVien.DataSource = ListModel(ds);
        }

        #region Chuyển Danh Sách Qua Dạng Model
        public List<Model_NhanVien> ListModel(List<NHANVIEN> ds)
        {
            List<Model_NhanVien> DS_NhanVien = new List<Model_NhanVien>();
            foreach (var item in ds)
            {
                Model_NhanVien model = new Model_NhanVien
                {
                    MaNV = item.MaNV,
                    TenNV = item.TenNV,
                    NgaySinh = item.NgaySinh,
                    GioiTinh = item.Phai,
                    DiaChi = item.DiaChi,
                    SDT = item.SDT,
                    ChucVu = item.ChucVu,
                };
                DS_NhanVien.Add(model);
            }
            return DS_NhanVien;
        }
        #endregion

        #region Hàm Kiểm Tra
        private bool KiemTra_Control()
        {
            if (txt_DiaChi.Text != "" && txt_NgaySinh.Text != "" && txt_SDT.Text != "" && txt_TenNV.Text != "")
                return true;
            else
                return false;
        }
        #endregion

        #region Thêm Xóa Sửa Nhân Viên
        private void btn_Add_Click(object sender, EventArgs e)
        {
            label14.Text = "Thêm Nhân Viên";
            panel3.Visible = true;
            dataGV_NhanVien.Visible = false;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            label14.Text = "Cập Nhật Nhân Viên";
            panel3.Visible = true;
            dataGV_NhanVien.Visible = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            bool kt = KiemTra_Control();
            if (kt == true)
            {
                string gt="Nam";
                if (radioButton_Nữ.Checked)
                    gt = radioButton_Nữ.Text;
                else
                    gt = "Name";
                NHANVIEN model = new NHANVIEN
                {
                    TenNV = txt_TenNV.Text,
                    NgaySinh = Convert.ToDateTime(txt_NgaySinh.Text),
                    Phai = gt,
                    DiaChi = txt_DiaChi.Text,
                    SDT = txt_SDT.Text,
                    ChucVu = comboBox_ChucVu.Text
                };
                
                if (label14.Text == "Cập Nhật Nhân Viên")
                {
                    int kq = _nhanVienDao.Update(model, Convert.ToInt32(label_maSP.Text));
                    if (kq == 1)
                    {
                        MessageBox.Show("Cập Nhật Nhân Viên Thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel3.Visible = false;
                        dataGV_NhanVien.Visible = true;
                        UC_NhanVien_Load(sender, e);
                    }
                }
                else
                {
                    int kq = _nhanVienDao.Add(model);
                    if (kq == 1)
                    {
                        MessageBox.Show("Thêm Nhân Viên Thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel3.Visible = false;
                        dataGV_NhanVien.Visible = true;
                        UC_NhanVien_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn Phải Nhập Đủ Các Thuộc Tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGV_NhanVien.Rows.Count > 0)
                {
                    int MaSP = Convert.ToInt32(dataGV_NhanVien.CurrentRow.Cells[0].Value);
                    var DSQuyen = _quyenDao.GetList(MaSP);
                    if (DSQuyen.Count() > 0)
                    {
                        _quyenDao.Delete(MaSP);
                    }
                    int kq = _nhanVienDao.Delete(MaSP);
                    if (kq == 1)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        UC_NhanVien_Load(sender, e);
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
        #endregion

        private void dataGV_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGV_NhanVien.Rows.Count > 0)
            {
                label_maSP.Text = dataGV_NhanVien.CurrentRow.Cells[0].Value.ToString();
                txt_TenNV.Text = dataGV_NhanVien.CurrentRow.Cells[1].Value.ToString();
                txt_NgaySinh.Text = dataGV_NhanVien.CurrentRow.Cells[2].Value.ToString();
                txt_DiaChi.Text = dataGV_NhanVien.CurrentRow.Cells[4].Value.ToString();
                txt_SDT.Text = dataGV_NhanVien.CurrentRow.Cells[5].Value.ToString();
                comboBox_ChucVu.Text = dataGV_NhanVien.CurrentRow.Cells[6].Value.ToString();
            }
        }

        #region Hàm Tìm Kiếm
        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(txt_TimKiem.Text != "")
            {
                var ds = _nhanVienDao.GetList(txt_TimKiem.Text);
                btn_Search.Text = "Back";
                dataGV_NhanVien.DataSource = ListModel(ds);
            }
        }
        #endregion

        private void btn_Back_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            dataGV_NhanVien.Visible = true;
        }
    }
}
