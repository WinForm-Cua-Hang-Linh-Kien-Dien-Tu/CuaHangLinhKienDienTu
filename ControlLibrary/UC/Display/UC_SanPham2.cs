using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlLibrary.UC.Add_Edit;
using DataLibrary.Dao;

namespace ControlLibrary.UC.Display
{
    public partial class UC_SanPham2 : UserControl
    {
        public UC_SanPham2()
        {
            InitializeComponent();
        }

        private int MaSP;

        private void btn_Add_Click(object sender, EventArgs e)
        {
            UC_Add_SanPham add_SanPham = new UC_Add_SanPham();
            panel_Container.Dock = DockStyle.Bottom;
            panel_Container.Controls.Add(add_SanPham);
            dataGV_SanPham.Visible = false;
            btn_Back.Visible = true;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            UC_Add_SanPham add_SanPham = new UC_Add_SanPham();
            dataGV_SanPham.Visible = true;
            add_SanPham.Visible = false;
            btn_Back.Visible = false;
            UC_SanPham2_Load(sender,e);
        }

        private void UC_SanPham2_Load(object sender, EventArgs e)
        {
            var dao = new SanPham();
            dataGV_SanPham.DataSource = dao.LoadSanPham();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                var dao = new SanPham();
                if (dataGV_SanPham.SelectedRows.Count > 0)
                {
                    MaSP = Convert.ToInt32(dataGV_SanPham.SelectedRows[0].Cells[0].Value);
                    bool kq = dao.Delete(MaSP);
                    if (kq == true)
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
<<<<<<< HEAD
            UC_Edit_SanPham edit_SanPham = new UC_Edit_SanPham();
            dataGV_SanPham.Visible = true;
            edit_SanPham.Visible = false;
            btn_Back.Visible = false;
=======
            UC_Add_SanPham add_SanPham = new UC_Add_SanPham();
            panel_Container.Dock = DockStyle.Bottom;
            panel_Container.Controls.Add(add_SanPham);
            dataGV_SanPham.Visible = false;
            btn_Back.Visible = true;
>>>>>>> 7c3858f7db9f86c4e85cae99f3dde9eff999fab3
        }
    }
}
