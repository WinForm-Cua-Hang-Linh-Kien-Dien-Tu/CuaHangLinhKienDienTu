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
using System.IO;
using System.Drawing.Imaging;

namespace ControlLibrary.UC.Add_Edit
{
    public partial class UC_Add_SanPham : UserControl
    {
        public UC_Add_SanPham()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    picBox_1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void btn_SaveImage_Click(object sender, EventArgs e)
        {

        }


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
           
                var dao = new SanPham();
                
                SANPHAM sp = new SANPHAM();

                sp.TenSP = txt_TenSP.Text.ToString();
                sp.MaNSX = Convert.ToInt32(dao.idMaNSX(comboBox_NSX.Text));
                sp.MaLoai = Convert.ToInt32(dao.idMaLoai(comboBox_LoaiSP.Text));
                sp.MoTa = txt_Mota.Text.ToString();
                sp.Gia = Convert.ToInt32(txt_Gia.Text);
                sp.SoLuong = Convert.ToInt32(txt_SoLuong.Text);
                sp.Size = txt_Size.Text.ToString();
                sp.XuatXu = txt_XuatXu.Text.ToString();
                sp.DacTinh = txt_DacTinh.Text.ToString();
                sp.Hinh = txt_HinhAnh.Text.ToString();
                   

                dao.AddNew(sp);

                MessageBox.Show("Tạo Thành Công", "Tin Nhắn", MessageBoxButtons.OK);
           
        }

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
    }
}
