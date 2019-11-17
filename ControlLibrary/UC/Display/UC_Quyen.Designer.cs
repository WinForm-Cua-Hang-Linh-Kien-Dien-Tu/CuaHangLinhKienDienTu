namespace ControlLibrary.UC.Display
{
    partial class UC_Quyen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_tool = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_DanhSachTaiKhoanTheoNhom = new System.Windows.Forms.ComboBox();
            this.dataGV_DSToanBoTK = new System.Windows.Forms.DataGridView();
            this.dataGV_DSTaiKhoanTheoNhom = new System.Windows.Forms.DataGridView();
            this.btn_ThemQuyen = new System.Windows.Forms.Button();
            this.btn_CatQuyen = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DSToanBoTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DSTaiKhoanTheoNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel_tool);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 73);
            this.panel2.TabIndex = 10;
            // 
            // panel_tool
            // 
            this.panel_tool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_tool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_tool.Location = new System.Drawing.Point(0, 71);
            this.panel_tool.Name = "panel_tool";
            this.panel_tool.Size = new System.Drawing.Size(847, 2);
            this.panel_tool.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phân quyền tài khoản người dùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Danh sách toàn bộ tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Danh sách tài khoản theo nhóm";
            // 
            // cbb_DanhSachTaiKhoanTheoNhom
            // 
            this.cbb_DanhSachTaiKhoanTheoNhom.FormattingEnabled = true;
            this.cbb_DanhSachTaiKhoanTheoNhom.Location = new System.Drawing.Point(566, 145);
            this.cbb_DanhSachTaiKhoanTheoNhom.Name = "cbb_DanhSachTaiKhoanTheoNhom";
            this.cbb_DanhSachTaiKhoanTheoNhom.Size = new System.Drawing.Size(215, 21);
            this.cbb_DanhSachTaiKhoanTheoNhom.TabIndex = 14;
            // 
            // dataGV_DSToanBoTK
            // 
            this.dataGV_DSToanBoTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_DSToanBoTK.Location = new System.Drawing.Point(18, 180);
            this.dataGV_DSToanBoTK.Name = "dataGV_DSToanBoTK";
            this.dataGV_DSToanBoTK.Size = new System.Drawing.Size(284, 342);
            this.dataGV_DSToanBoTK.TabIndex = 15;
            // 
            // dataGV_DSTaiKhoanTheoNhom
            // 
            this.dataGV_DSTaiKhoanTheoNhom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_DSTaiKhoanTheoNhom.Location = new System.Drawing.Point(538, 180);
            this.dataGV_DSTaiKhoanTheoNhom.Name = "dataGV_DSTaiKhoanTheoNhom";
            this.dataGV_DSTaiKhoanTheoNhom.Size = new System.Drawing.Size(284, 342);
            this.dataGV_DSTaiKhoanTheoNhom.TabIndex = 16;
            // 
            // btn_ThemQuyen
            // 
            this.btn_ThemQuyen.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemQuyen.Location = new System.Drawing.Point(362, 240);
            this.btn_ThemQuyen.Name = "btn_ThemQuyen";
            this.btn_ThemQuyen.Size = new System.Drawing.Size(107, 52);
            this.btn_ThemQuyen.TabIndex = 17;
            this.btn_ThemQuyen.Text = "Thêm quyền";
            this.btn_ThemQuyen.UseVisualStyleBackColor = true;
            // 
            // btn_CatQuyen
            // 
            this.btn_CatQuyen.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CatQuyen.Location = new System.Drawing.Point(362, 321);
            this.btn_CatQuyen.Name = "btn_CatQuyen";
            this.btn_CatQuyen.Size = new System.Drawing.Size(107, 52);
            this.btn_CatQuyen.TabIndex = 18;
            this.btn_CatQuyen.Text = "Cắt quyền";
            this.btn_CatQuyen.UseVisualStyleBackColor = true;
            // 
            // UC_Quyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_CatQuyen);
            this.Controls.Add(this.btn_ThemQuyen);
            this.Controls.Add(this.dataGV_DSTaiKhoanTheoNhom);
            this.Controls.Add(this.dataGV_DSToanBoTK);
            this.Controls.Add(this.cbb_DanhSachTaiKhoanTheoNhom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Name = "UC_Quyen";
            this.Size = new System.Drawing.Size(847, 542);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DSToanBoTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_DSTaiKhoanTheoNhom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_tool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_DanhSachTaiKhoanTheoNhom;
        private System.Windows.Forms.DataGridView dataGV_DSToanBoTK;
        private System.Windows.Forms.DataGridView dataGV_DSTaiKhoanTheoNhom;
        private System.Windows.Forms.Button btn_ThemQuyen;
        private System.Windows.Forms.Button btn_CatQuyen;
    }
}
