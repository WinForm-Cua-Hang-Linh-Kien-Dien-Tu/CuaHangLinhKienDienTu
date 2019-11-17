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
using DataLibrary.Model;
using DataLibrary.EF;

namespace ControlLibrary.UC.Add_Edit
{
    public partial class UC_Add_SanPham : UserControl
    {
        public UC_Add_SanPham()
        {
            InitializeComponent();
        }

        private int? maNSX, maLoai, soLuong;
        private string tenSP, moTa;
        private decimal? gia;
        private string size, xuatXu, dacTinh, hinh;

        private void UC_Add_SanPham_Load(object sender, EventArgs e)
        {
            var dao = new SanPham();
            foreach (SanPhamModel item in dao.loadTenNSX())
            {
                comboBox_NSX.Items.Add(item.TenNSX);
            }
            foreach (SanPhamModel item in dao.loadTenLoai())
            {
                comboBox_LoaiSP.Items.Add(item.TenLoai);
            }
        }

      
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                var dao = new SanPham();

                tenSP = txt_TenSP.Text.ToString();
                maNSX = Convert.ToInt32(dao.idMaNSX(comboBox_NSX.Text));
                maLoai = Convert.ToInt32(dao.idMaLoai(comboBox_LoaiSP.Text));
                moTa = txt_Mota.Text.ToString();
                gia = Convert.ToInt32(txt_Gia.Text);
                soLuong = Convert.ToInt32(txt_SoLuong.Text);
                size = txt_Size.Text.ToString();
                xuatXu = txt_XuatXu.Text.ToString();
                dacTinh = txt_DacTinh.Text.ToString();
                hinh = txt_HinhAnh.Text.ToString();

                
                SanPhamModel sp = new SanPhamModel(maNSX, maLoai, tenSP, moTa, gia, soLuong, size, xuatXu, dacTinh, hinh);
                dao.AddNew(sp);

                MessageBox.Show("Tạo Thành Công", "Tin Nhắn", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Tạo Thất Bại", "Tin Nhắn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
