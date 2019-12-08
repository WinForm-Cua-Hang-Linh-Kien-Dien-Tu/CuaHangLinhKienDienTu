using System;

namespace Form_Main
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_KhachHang = new System.Windows.Forms.Button();
            this.btn_Quyen = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.pn_Chuyen = new System.Windows.Forms.Panel();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.btn_SanPham = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ThongKe = new System.Windows.Forms.Button();
            this.btn_DonHang = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.uC_DonHang1 = new ControlLibrary.UC.Display.UC_DonHang();
            this.uC_NhanVien1 = new ControlLibrary.UC.Display.UC_NhanVien();
            this.uC_KhachHang1 = new ControlLibrary.UC.Display.UC_KhachHang();
            this.uC_UserProfile1 = new ControlLibrary.UC.Display.UC_UserProfile();
            this.uC_Quyen1 = new ControlLibrary.UC.Display.UC_Quyen();
            this.uC_NhaCungCap1 = new ControlLibrary.UC.Display.UC_NhaCungCap();
            this.uC_HoaDon1 = new ControlLibrary.UC.Display.UC_HoaDon();
            this.uC_SanPham21 = new ControlLibrary.UC.Display.UC_SanPham2();
            this.uC_Loai1 = new ControlLibrary.UC.Display.UC_Loai();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_KhachHang.FlatAppearance.BorderSize = 0;
            this.btn_KhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_KhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_KhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KhachHang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhachHang.ForeColor = System.Drawing.Color.White;
            this.btn_KhachHang.Location = new System.Drawing.Point(11, 175);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Size = new System.Drawing.Size(198, 54);
            this.btn_KhachHang.TabIndex = 5;
            this.btn_KhachHang.Text = "Khách Hàng";
            this.btn_KhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_KhachHang.UseVisualStyleBackColor = true;
            this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
            // 
            // btn_Quyen
            // 
            this.btn_Quyen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_Quyen.FlatAppearance.BorderSize = 0;
            this.btn_Quyen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_Quyen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_Quyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Quyen.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quyen.ForeColor = System.Drawing.Color.White;
            this.btn_Quyen.Location = new System.Drawing.Point(11, 355);
            this.btn_Quyen.Name = "btn_Quyen";
            this.btn_Quyen.Size = new System.Drawing.Size(198, 54);
            this.btn_Quyen.TabIndex = 9;
            this.btn_Quyen.Text = "Quyền";
            this.btn_Quyen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Quyen.UseVisualStyleBackColor = true;
            this.btn_Quyen.Click += new System.EventHandler(this.btn_Quyen_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.button12);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(216, 49);
            this.panel4.TabIndex = 6;
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::Form_Main.Properties.Resources.Logo;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.Enabled = false;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(0, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(216, 49);
            this.button12.TabIndex = 12;
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // pn_Chuyen
            // 
            this.pn_Chuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.pn_Chuyen.Location = new System.Drawing.Point(0, 51);
            this.pn_Chuyen.Name = "pn_Chuyen";
            this.pn_Chuyen.Size = new System.Drawing.Size(10, 57);
            this.pn_Chuyen.TabIndex = 0;
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_NhanVien.FlatAppearance.BorderSize = 0;
            this.btn_NhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_NhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_NhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhanVien.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhanVien.ForeColor = System.Drawing.Color.White;
            this.btn_NhanVien.Location = new System.Drawing.Point(11, 295);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(198, 54);
            this.btn_NhanVien.TabIndex = 4;
            this.btn_NhanVien.Text = "Nhân Viên";
            this.btn_NhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhanVien.UseVisualStyleBackColor = true;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quản Lý Cửa Hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_LogOut);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_Exit);
            this.panel2.Location = new System.Drawing.Point(216, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 49);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quản Lý ";
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackgroundImage = global::Form_Main.Properties.Resources.DangXuat;
            this.btn_LogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_LogOut.FlatAppearance.BorderSize = 0;
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.Location = new System.Drawing.Point(733, 10);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(23, 29);
            this.btn_LogOut.TabIndex = 13;
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::Form_Main.Properties.Resources.setting;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(772, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(27, 34);
            this.button9.TabIndex = 12;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackgroundImage = global::Form_Main.Properties.Resources.shutdown;
            this.btn_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(805, 3);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(39, 42);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_HoaDon.FlatAppearance.BorderSize = 0;
            this.btn_HoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_HoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_HoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoaDon.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HoaDon.ForeColor = System.Drawing.Color.White;
            this.btn_HoaDon.Location = new System.Drawing.Point(11, 115);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(198, 54);
            this.btn_HoaDon.TabIndex = 3;
            this.btn_HoaDon.Text = "Hóa Đơn";
            this.btn_HoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HoaDon.UseVisualStyleBackColor = true;
            this.btn_HoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_SanPham.FlatAppearance.BorderSize = 0;
            this.btn_SanPham.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_SanPham.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_SanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SanPham.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SanPham.ForeColor = System.Drawing.Color.White;
            this.btn_SanPham.Location = new System.Drawing.Point(11, 55);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Size = new System.Drawing.Size(198, 54);
            this.btn_SanPham.TabIndex = 2;
            this.btn_SanPham.Text = "Sản Phẩm";
            this.btn_SanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SanPham.UseVisualStyleBackColor = true;
            this.btn_SanPham.Click += new System.EventHandler(this.btn_SanPham_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btn_ThongKe);
            this.panel1.Controls.Add(this.btn_DonHang);
            this.panel1.Controls.Add(this.btn_KhachHang);
            this.panel1.Controls.Add(this.btn_Quyen);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.pn_Chuyen);
            this.panel1.Controls.Add(this.btn_NhanVien);
            this.panel1.Controls.Add(this.btn_HoaDon);
            this.panel1.Controls.Add(this.btn_SanPham);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 593);
            this.panel1.TabIndex = 3;
            // 
            // btn_ThongKe
            // 
            this.btn_ThongKe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_ThongKe.FlatAppearance.BorderSize = 0;
            this.btn_ThongKe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_ThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_ThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThongKe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThongKe.ForeColor = System.Drawing.Color.White;
            this.btn_ThongKe.Location = new System.Drawing.Point(11, 412);
            this.btn_ThongKe.Name = "btn_ThongKe";
            this.btn_ThongKe.Size = new System.Drawing.Size(198, 54);
            this.btn_ThongKe.TabIndex = 12;
            this.btn_ThongKe.Text = "Thống Kê";
            this.btn_ThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThongKe.UseVisualStyleBackColor = true;
            this.btn_ThongKe.Click += new System.EventHandler(this.btn_ThongKe_Click);
            // 
            // btn_DonHang
            // 
            this.btn_DonHang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_DonHang.FlatAppearance.BorderSize = 0;
            this.btn_DonHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_DonHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btn_DonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DonHang.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DonHang.ForeColor = System.Drawing.Color.White;
            this.btn_DonHang.Location = new System.Drawing.Point(11, 235);
            this.btn_DonHang.Name = "btn_DonHang";
            this.btn_DonHang.Size = new System.Drawing.Size(198, 54);
            this.btn_DonHang.TabIndex = 11;
            this.btn_DonHang.Text = "Đơn Hàng";
            this.btn_DonHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DonHang.UseVisualStyleBackColor = true;
            this.btn_DonHang.Click += new System.EventHandler(this.btn_DonHang_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.uC_DonHang1);
            this.panelContainer.Controls.Add(this.uC_NhanVien1);
            this.panelContainer.Controls.Add(this.uC_KhachHang1);
            this.panelContainer.Controls.Add(this.uC_UserProfile1);
            this.panelContainer.Controls.Add(this.uC_Quyen1);
            this.panelContainer.Controls.Add(this.uC_NhaCungCap1);
            this.panelContainer.Controls.Add(this.uC_HoaDon1);
            this.panelContainer.Controls.Add(this.uC_SanPham21);
            this.panelContainer.Controls.Add(this.uC_Loai1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelContainer.Location = new System.Drawing.Point(216, 51);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(847, 542);
            this.panelContainer.TabIndex = 5;
            // 
            // uC_DonHang1
            // 
            this.uC_DonHang1.BackColor = System.Drawing.Color.White;
            this.uC_DonHang1.Location = new System.Drawing.Point(0, 0);
            this.uC_DonHang1.Name = "uC_DonHang1";
            this.uC_DonHang1.Size = new System.Drawing.Size(847, 542);
            this.uC_DonHang1.TabIndex = 10;
            // 
            // uC_NhanVien1
            // 
            this.uC_NhanVien1.BackColor = System.Drawing.Color.White;
            this.uC_NhanVien1.Location = new System.Drawing.Point(3, -3);
            this.uC_NhanVien1.Name = "uC_NhanVien1";
            this.uC_NhanVien1.Size = new System.Drawing.Size(844, 542);
            this.uC_NhanVien1.TabIndex = 9;
            // 
            // uC_KhachHang1
            // 
            this.uC_KhachHang1.BackColor = System.Drawing.Color.White;
            this.uC_KhachHang1.Location = new System.Drawing.Point(0, -3);
            this.uC_KhachHang1.Name = "uC_KhachHang1";
            this.uC_KhachHang1.Size = new System.Drawing.Size(847, 542);
            this.uC_KhachHang1.TabIndex = 8;
            // 
            // uC_UserProfile1
            // 
            this.uC_UserProfile1.BackColor = System.Drawing.Color.White;
            this.uC_UserProfile1.Location = new System.Drawing.Point(-2, -1);
            this.uC_UserProfile1.Name = "uC_UserProfile1";
            this.uC_UserProfile1.Size = new System.Drawing.Size(847, 542);
            this.uC_UserProfile1.TabIndex = 7;
            // 
            // uC_Quyen1
            // 
            this.uC_Quyen1.BackColor = System.Drawing.Color.White;
            this.uC_Quyen1.Location = new System.Drawing.Point(0, -4);
            this.uC_Quyen1.Name = "uC_Quyen1";
            this.uC_Quyen1.Size = new System.Drawing.Size(847, 546);
            this.uC_Quyen1.TabIndex = 6;
            // 
            // uC_NhaCungCap1
            // 
            this.uC_NhaCungCap1.Location = new System.Drawing.Point(0, -3);
            this.uC_NhaCungCap1.Name = "uC_NhaCungCap1";
            this.uC_NhaCungCap1.Size = new System.Drawing.Size(847, 542);
            this.uC_NhaCungCap1.TabIndex = 4;
            // 
            // uC_HoaDon1
            // 
            this.uC_HoaDon1.BackColor = System.Drawing.Color.White;
            this.uC_HoaDon1.Location = new System.Drawing.Point(-2, -4);
            this.uC_HoaDon1.Name = "uC_HoaDon1";
            this.uC_HoaDon1.Size = new System.Drawing.Size(847, 542);
            this.uC_HoaDon1.TabIndex = 3;
            // 
            // uC_SanPham21
            // 
            this.uC_SanPham21.BackColor = System.Drawing.Color.White;
            this.uC_SanPham21.Location = new System.Drawing.Point(0, 0);
            this.uC_SanPham21.Name = "uC_SanPham21";
            this.uC_SanPham21.Size = new System.Drawing.Size(847, 542);
            this.uC_SanPham21.TabIndex = 2;
            // 
            // uC_Loai1
            // 
            this.uC_Loai1.Location = new System.Drawing.Point(-1, -4);
            this.uC_Loai1.Name = "uC_Loai1";
            this.uC_Loai1.Size = new System.Drawing.Size(847, 542);
            this.uC_Loai1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 593);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Button btn_KhachHang;
        private System.Windows.Forms.Button btn_Quyen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel pn_Chuyen;
        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_HoaDon;
        private System.Windows.Forms.Button btn_SanPham;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContainer;
        private ControlLibrary.UC.Display.UC_Loai uC_Loai1;
        private ControlLibrary.UC.Display.UC_NhaCungCap uC_NhaCungCap1;
        private ControlLibrary.UC.Display.UC_HoaDon uC_HoaDon1;
        private ControlLibrary.UC.Display.UC_SanPham2 uC_SanPham21;
        private ControlLibrary.UC.Display.UC_Quyen uC_Quyen1;
        private ControlLibrary.UC.Display.UC_UserProfile uC_UserProfile1;
        private ControlLibrary.UC.Display.UC_KhachHang uC_KhachHang1;
        private System.Windows.Forms.Button btn_DonHang;
        private ControlLibrary.UC.Display.UC_NhanVien uC_NhanVien1;
        private System.Windows.Forms.Button btn_ThongKe;
        private ControlLibrary.UC.Display.UC_DonHang uC_DonHang1;
        private System.Windows.Forms.Label label1;
    }
}

