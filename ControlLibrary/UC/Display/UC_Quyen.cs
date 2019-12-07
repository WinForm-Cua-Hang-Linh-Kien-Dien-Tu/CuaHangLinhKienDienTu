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
    public partial class UC_Quyen : UserControl
    {
        public UC_Quyen()
        {
            InitializeComponent();
        }

        #region Biến Kết Nối Dao
        quyenDao _quyenDao = new quyenDao();
        nhanVienDao _nhanVienDao = new nhanVienDao();
        #endregion

        private void UC_Quyen_Load(object sender, EventArgs e)
        {
            combo_TenNV.DataSource = _nhanVienDao.GetDSTenNV();
            dataGV_DSTaiKhoan.DataSource = ListModel(_quyenDao.GetList());
            dataGV_DSTheoNhom.DataSource = ListModel(_quyenDao.GetList(combo_Quyen.Text));
        }

        #region Chuyển Đổi Danh Sách Sang Kiểu Model
        public List<Model_Quyen> ListModel(List<QUYEN> ds)
        {
            List<Model_Quyen> DS_NhanVien = new List<Model_Quyen>();
            foreach (var item in ds)
            {
                Model_Quyen model = new Model_Quyen
                {
                    ID = item.ID,
                    MaNV = item.MaNV,
                    TenNV = _nhanVienDao.GetDVByMa(item.MaNV).TenNV,
                    User = item.User,
                    PassWord = item.PassWord,
                    Quyen = item.Quyen1
                };
                DS_NhanVien.Add(model);
            }
            return DS_NhanVien;
        }
        #endregion

        private void combo_Quyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGV_DSTheoNhom.DataSource = ListModel(_quyenDao.GetList(combo_Quyen.Text));
        }

        #region Hàm Kiểm Tra
        bool KiemTra_Control()
        {
            if (txt_userName.Text != "" && txt_Pass.Text != null)
                return true;
            else
                return false;
        }

        int kt_User(string a, string ten)
        {
            var item = _quyenDao.GetDVByMa(a);
            int b = _nhanVienDao.GetDVByMa(ten).MaNV;
            var item2 = _quyenDao.GetQuyenByMaNV(b);
            if (item != null)
                return 1;
            else
            {
                if (item2 != null)
                    return 2;
                else
                    return 0;
            }
        }
        #endregion

        #region Thêm Xóa Sửa Tài Khoản
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                bool kt = KiemTra_Control();
                int kt_UserName = kt_User(txt_userName.Text, combo_TenNV.Text);
                if (kt)
                {
                    if (kt_UserName == 0)
                    {
                        QUYEN q = new QUYEN
                        {
                            MaNV = _nhanVienDao.GetDVByMa(combo_TenNV.Text).MaNV,
                            User = txt_userName.Text,
                            PassWord = txt_Pass.Text,
                            Quyen1 = ""
                        };
                        int kq = _quyenDao.Add(q);
                        if (kq == 1)
                        {
                            MessageBox.Show("Thêm Tài Thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            UC_Quyen_Load(sender,e);
                        }
                    }
                    else
                    {
                        if (kt_UserName == 2)
                        {
                            MessageBox.Show("Tài Khoản Này Đã Tồn Tại. Vui Lòng Nhập UserName Khác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn Chưa Điền Đủ Các Trường", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Đường Dẫn Bị Lỗi Rồi Đại Vương Ơi (^_^)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                int ma = Convert.ToInt32(dataGV_DSTaiKhoan.CurrentRow.Cells[0].Value);
                QUYEN q = new QUYEN
                {
                    User = txt_userName.Text,
                    PassWord = txt_Pass.Text
                };
                int kq = _quyenDao.UpdateHoanChinh(q, Convert.ToInt32(label_MaNV.Text));
                if (kq == 1)
                {
                    MessageBox.Show("Cập Nhật Thông Tin Tài Khoản Thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UC_Quyen_Load(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Đường Truyền Bị Lỗi Rồi Đại Vương Ơi(^_^)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                var dao = new SanPham();
                if (dataGV_DSTaiKhoan.Rows.Count > 0)
                {
                    int MaSP = Convert.ToInt32(dataGV_DSTaiKhoan.CurrentRow.Cells[1].Value);
                    int kq = _quyenDao.Delete(MaSP);
                    if (kq == 1)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        UC_Quyen_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Xóa Thất Bại");
                }
            }
            catch
            {
                MessageBox.Show("Đường Truyền Bị Lỗi Rồi Đại Vương Ơi(^_^)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
        #endregion

        #region Phân Quyền Cho tài Khoản
        private void btn_Search_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(dataGV_DSTaiKhoan.CurrentRow.Cells[1].Value);
            QUYEN q = new QUYEN
            {
                Quyen1 = combo_Quyen.Text
            };
            int kq = _quyenDao.Update(q, ma);
            if (kq == 1)
            {
                MessageBox.Show("Tạo Quyền Cho  Thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UC_Quyen_Load(sender, e);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(dataGV_DSTheoNhom.CurrentRow.Cells[1].Value);
            QUYEN q = new QUYEN
            {
                Quyen1 = ""
            };
            int kq = _quyenDao.Update(q, ma);
            if (kq == 1)
            {
                MessageBox.Show("Xóa Quyền Của Tài Khoản Thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UC_Quyen_Load(sender, e);
            }
        }
        #endregion

        private void dataGV_DSTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGV_DSTaiKhoan.Rows.Count > 0)
            {
                label_MaNV.Text = dataGV_DSTaiKhoan.CurrentRow.Cells[1].Value.ToString();
                txt_userName.Text = dataGV_DSTaiKhoan.CurrentRow.Cells[3].Value.ToString();
                txt_Pass.Text = dataGV_DSTaiKhoan.CurrentRow.Cells[4].Value.ToString();
                combo_TenNV.Text = dataGV_DSTaiKhoan.CurrentRow.Cells[2].Value.ToString();
               
            }
        }

        #region Load Click
        private void btn_Load_Click(object sender, EventArgs e)
        {
            UC_Quyen_Load(sender, e);
        }
        #endregion
    }
}
