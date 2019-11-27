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


        private void UC_Edit_SanPham_Load(object sender, EventArgs e)
        {
            
        }

       

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                var dao = new SanPham();

               
                SANPHAM sp = new SANPHAM();

                sp.TenSP = txt_TenSP.Text.ToString();
                sp.MaNSX = Convert.ToInt32(dao.idMaNSX(comboBox_NSX.Text));
                sp.MaLoai = Convert.ToInt32(dao.idMaLoai(comboBox_LoaiSP.Text));
                sp.MoTa = txt_MoTa.Text.ToString();
                sp.Gia = Convert.ToInt32(txt_Gia.Text);
                sp.SoLuong = Convert.ToInt32(txt_SoLuong.Text);
                sp.Size = txt_Size.Text.ToString();
                sp.XuatXu = txt_XuatXu.Text.ToString();
                sp.DacTinh = txt_DacTinh.Text.ToString();
                sp.Hinh = txt_Hinh.Text.ToString();
                 
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
