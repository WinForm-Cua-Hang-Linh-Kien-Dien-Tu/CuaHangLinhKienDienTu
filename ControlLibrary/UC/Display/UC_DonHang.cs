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
    public partial class UC_DonHang : UserControl
    {
        public UC_DonHang()
        {
            InitializeComponent();
        }

        donHangDao _donHangDao = new donHangDao();
        khachHangDao _khachHangDao = new khachHangDao();

        private void UC_DonHang_Load(object sender, EventArgs e)
        {
            dataGV_DonHang.DataSource = ListModel(_donHangDao.GetList());
        }

        #region Chuyển Danh Sách Qua Dạng Model
        public List<Model_DonHang> ListModel(List<DONHANG> ds)
        {
            List<Model_DonHang> DS_NhanVien = new List<Model_DonHang>();
            foreach (var item in ds)
            {
                Model_DonHang model = new Model_DonHang
                {
                    ID = item.ID,
                    MaHD = item.MaHD,
                    MaKH = item.MaKH,
                    TenKH = _khachHangDao.GetDVByMa(item.MaKH).TenKH,
                    NgayDat = item.NgayDat,
                    TrangThai = item.TrangThai
                };
                DS_NhanVien.Add(model);
            }
            return DS_NhanVien;
        }
        #endregion
        void UpdateTrangThai(string trangThai, string message)
        {
            try
            {
                int id = Convert.ToInt32(dataGV_DonHang.CurrentRow.Cells[0].Value);
                DateTime ngayDat = Convert.ToDateTime(dataGV_DonHang.CurrentRow.Cells[4].Value);
                DONHANG dh = new DONHANG
                {
                    ID = id,
                    TrangThai = trangThai,
                    NgayDat = ngayDat
                };
                int kq = _donHangDao.Update(dh);
                if (kq == 1)
                {
                    MessageBox.Show(message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập Nhật Trạng Thái Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch
            {
                MessageBox.Show("Đường Truyền Bị Lỗi Rồi Đại Vương Ơi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            UpdateTrangThai("Đã Xác Nhận","Đã Xác Nhận Đơn Hàng");
            UC_DonHang_Load(sender, e);
        }

        private void btn_GiaoHang_Click(object sender, EventArgs e)
        {
            UpdateTrangThai("Giao Hàng", "Đã Giao Hàng Đơn Hàng");
            UC_DonHang_Load(sender, e);
        }

        private void btn_HoanThanh_Click(object sender, EventArgs e)
        {
            UpdateTrangThai("Hoàn Thành", "Hoàn Thành Đơn Hàng");
            UC_DonHang_Load(sender, e);
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGV_DonHang.Rows.Count > 0)
                {
                    int MaHD = Convert.ToInt32(dataGV_DonHang.CurrentRow.Cells[0].Value);
                    
                    int kq = _donHangDao.Delete(MaHD);
                    if (kq == 1)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        UC_DonHang_Load(sender, e);
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

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void dataGV_DonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGV_DonHang.Rows.Count > 0)
                {
                    string trangThai = dataGV_DonHang.CurrentRow.Cells[5].Value.ToString();
                    if(trangThai == "Chưa Xác Nhận")
                    {
                        btn_GiaoHang.Enabled = false;
                        btn_XacNhan.Enabled = true;
                        btn_HoanThanh.Enabled = false;
                    }
                    else
                    {
                        if(trangThai == "Đã Xác Nhận")
                        {
                            btn_GiaoHang.Enabled = true;
                            btn_XacNhan.Enabled = false;
                            btn_HoanThanh.Enabled = false;
                        }
                        else
                        {
                            if (trangThai == "Giao Hàng")
                            {
                                btn_XacNhan.Enabled = false;
                                btn_GiaoHang.Enabled = false;
                                btn_HoanThanh.Enabled = true;
                            }
                            else
                            {
                                btn_GiaoHang.Enabled = false;
                                btn_XacNhan.Enabled = false;
                                btn_HoanThanh.Enabled = false;
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Đường Truyền Bị Lỗi Rồi Đại Vương Ơi","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_DonHang_Load(sender,e);
        }
    }
}
