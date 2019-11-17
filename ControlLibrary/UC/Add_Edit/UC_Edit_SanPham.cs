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
using DataLibrary.EF;
using ControlLibrary.UC.Display;

namespace ControlLibrary.UC.Add_Edit
{
    public partial class UC_Edit_SanPham : UserControl
    {
        public UC_Edit_SanPham()
        {
            InitializeComponent();
            
        }

        private int? maNSX, maLoai, soLuong;
        private string tenSP, moTa;
        private decimal? gia;
        private string size, xuatXu, dacTinh, hinh;

        private void UC_Edit_SanPham_Load(object sender, EventArgs e)
        {
            
        }

       

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                var dao = new SanPham();

                tenSP = txt_TenSP.Text.ToString();
                maNSX = Convert.ToInt32(dao.idMaNSX(comboBox_NSX.Text));
                maLoai = Convert.ToInt32(dao.idMaLoai(comboBox_LoaiSP.Text));
                moTa = txt_MoTa.Text.ToString();
                gia = Convert.ToInt32(txt_Gia.Text);
                soLuong = Convert.ToInt32(txt_SoLuong.Text);
                size = txt_Size.Text.ToString();
                xuatXu = txt_XuatXu.Text.ToString();
                dacTinh = txt_DacTinh.Text.ToString();
                hinh = txt_Hinh.Text.ToString();


                SANPHAM sp = new SANPHAM(maNSX, maLoai, tenSP, moTa, gia, soLuong, size, xuatXu, dacTinh, hinh);
                dao.Edit(37, sp);

                MessageBox.Show("upadte Thành Công", "Tin Nhắn", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Update Thất Bại", "Tin Nhắn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
