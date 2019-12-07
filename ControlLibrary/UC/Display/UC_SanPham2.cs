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
using System.IO;
using System.Drawing.Imaging;
using ControlLibrary.Model;
using DataLibrary.EF;

namespace ControlLibrary.UC.Display
{
    public partial class UC_SanPham2 : UserControl
    {
        public UC_SanPham2()
        {
            InitializeComponent();
        }

        SanPham _sanPhamDao = new SanPham();
        nhaSanXuatDao _nhaSanXuatDao = new nhaSanXuatDao();
        loaiDao _loaiDao = new loaiDao();

        private void btn_Add_Click(object sender, EventArgs e)
        {
            label14.Text = "Thêm Sản Phẩm";
            panel3.Visible = true;
            dataGV_SanPham.Visible = false;
        }

        private void UC_SanPham2_Load(object sender, EventArgs e)
        {
            var ds = _sanPhamDao.GetList();
           
            dataGV_SanPham.DataSource = ListModel(ds);
            comboBox_NSX.DataSource = _nhaSanXuatDao.GetDSTen();
            comboBox_nhaSX.DataSource = _nhaSanXuatDao.GetDSTen();
            comboBox_LoaiSP.DataSource = _loaiDao.GetDSTen();
            combo_TimKiemLoai.DataSource = _loaiDao.GetDSTen();
        }

        public List<Model_SanPham> ListModel(List<SANPHAM> ds)
        {
            List<Model_SanPham> DS_SanPham = new List<Model_SanPham>();
            foreach (var item in ds)
            {
                Model_SanPham model = new Model_SanPham
                {
                    MaSP = item.MaSP,
                    TenSP = item.TenSP,
                    TenNSX = _nhaSanXuatDao.GetDVByMa(item.MaNSX).TenNSX,
                    TenLoai = _loaiDao.GetDVByMa(item.MaLoai).TenLoai,
                    Gia = item.Gia,
                    SoLuong = item.SoLuong,
                    Size = item.Size,
                    XuatXu = item.XuatXu,
                    DacTinh = item.DacTinh
                };
                DS_SanPham.Add(model);
            }
            return DS_SanPham;
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                var dao = new SanPham();
                if (dataGV_SanPham.SelectedRows.Count > 0)
                {
                    int MaSP = Convert.ToInt32(dataGV_SanPham.SelectedRows[0].Cells[0].Value);
                    int kq = _sanPhamDao.Delete(MaSP);
                    if (kq == 1)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        UC_SanPham2_Load(sender, e);
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



        private void btn_Edit_Click(object sender, EventArgs e)
        {
            label14.Text = "Cập Nhật Sản Phẩm";
            panel3.Visible = true;
            dataGV_SanPham.Visible = false;
        }

        #region UpFile Image
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        Image ConvertBinaryToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            return Image.FromStream(ms);
        }
        #endregion

        public bool KiemTra_Control()
        {
            if (txt_DacTinh.Text != "" && txt_Gia.Text != "" && txt_HinhAnh.Text != "" && txt_Mota.Text != "" &&
                txt_Size.Text != "" && txt_SoLuong.Text != "" && txt_TenSP.Text != "" && txt_XuatXu.Text != "")
                return true;
            else
                return false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_TimKiem.Text != "")
            {
                if (btn_Search.Text == "Search")
                {
                    var ds = _sanPhamDao.GetList(txt_TimKiem.Text);

                    dataGV_SanPham.DataSource = ListModel(ds);
                    btn_Search.Text = "Back";
                }
                else
                {
                    var ds = _sanPhamDao.GetList();

                    dataGV_SanPham.DataSource = ListModel(ds);
                    btn_Search.Text = "Search";
                }
            }
        }

        private void btn_Back_Click_1(object sender, EventArgs e)
        {
            panel3.Visible = false;
            dataGV_SanPham.Visible = true;
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picBox_1.Image = Image.FromFile(ofd.FileName);
                    txt_HinhAnh.Text = ofd.FileName.ToString();
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            bool kt = KiemTra_Control();
            if (kt == true)
            {
                SANPHAM sp = new SANPHAM
                {
                    MaNSX = _nhaSanXuatDao.GetDVByMa(comboBox_NSX.Text).MaNSX,
                    MaLoai = _loaiDao.GetDVByMa(comboBox_LoaiSP.Text).MaLoai,
                    TenSP = txt_TenSP.Text,
                    MoTa = txt_Mota.Text,
                    Gia = Convert.ToInt32(txt_Gia.Text),
                    SoLuong = Convert.ToInt32(txt_SoLuong.Text),
                    Size = txt_Size.Text,
                    XuatXu = txt_XuatXu.Text,
                    DacTinh = txt_DacTinh.Text,
                    Hinh = txt_HinhAnh.Text,
                };
                if (label14.Text == "Cập Nhật Sản Phẩm")
                {
                    int kq = _sanPhamDao.Update(sp, Convert.ToInt32(label_maSP.Text));
                    if (kq == 1)
                    {
                        MessageBox.Show("Cập Nhật Phẩm Thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel3.Visible = false;
                        dataGV_SanPham.Visible = true;
                        UC_SanPham2_Load(sender, e);
                    }
                }
                else
                {
                    int kq = _sanPhamDao.Add(sp);
                    if (kq == 1)
                    {
                        MessageBox.Show("Thêm Sản Phẩm Thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel3.Visible = false;
                        dataGV_SanPham.Visible = true;
                        UC_SanPham2_Load(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn Phải Nhập Đủ Các Thuộc Tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGV_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGV_SanPham.Rows.Count > 0)
                {
                    label_maSP.Text = dataGV_SanPham.CurrentRow.Cells[0].Value.ToString();
                    comboBox_NSX.Text = dataGV_SanPham.CurrentRow.Cells[1].Value.ToString();
                    comboBox_LoaiSP.Text = dataGV_SanPham.CurrentRow.Cells[2].Value.ToString();
                    txt_TenSP.Text = dataGV_SanPham.CurrentRow.Cells[3].Value.ToString();
                    txt_Gia.Text = dataGV_SanPham.CurrentRow.Cells[4].Value.ToString();
                    txt_SoLuong.Text = dataGV_SanPham.CurrentRow.Cells[5].Value.ToString();
                    txt_Size.Text = dataGV_SanPham.CurrentRow.Cells[6].Value.ToString();
                    txt_XuatXu.Text = dataGV_SanPham.CurrentRow.Cells[7].Value.ToString();
                    txt_DacTinh.Text = dataGV_SanPham.CurrentRow.Cells[8].Value.ToString();
                }
            }
            catch
            { }
        }

        private void combo_TimKiemLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<SANPHAM> ds;

            if (combo_TimKiemLoai.Text == "All")
            {
                ds = _sanPhamDao.GetList();
            }
            else
            {
                int maLoai = _loaiDao.GetDVByMa(combo_TimKiemLoai.Text).MaLoai;
                ds = _sanPhamDao.GetListLoai(maLoai);
            }
            
            dataGV_SanPham.DataSource = ListModel(ds);
        }

        private void comboBox_nhaSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<SANPHAM> ds;

            if (comboBox_nhaSX.Text == "All")
            {
                ds = _sanPhamDao.GetList();
            }
            else
            {
                int maNSX = _nhaSanXuatDao.GetDVByMa(comboBox_nhaSX.Text).MaNSX;
                ds = _sanPhamDao.GetListNSX(maNSX);
            }
           
            dataGV_SanPham.DataSource = ListModel(ds);
        }
    }
}
