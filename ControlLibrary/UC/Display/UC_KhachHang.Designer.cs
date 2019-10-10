namespace ControlLibrary.UC.Display
{
    partial class UC_KhachHang
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
            this.btn_Remove_KhachHang = new System.Windows.Forms.Button();
            this.btn_Edit_KhachHang = new System.Windows.Forms.Button();
            this.btn_Add_KhachHang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Search_KhachHang = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGV_KhachHang = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel_tool);
            this.panel2.Controls.Add(this.btn_Remove_KhachHang);
            this.panel2.Controls.Add(this.btn_Edit_KhachHang);
            this.panel2.Controls.Add(this.btn_Add_KhachHang);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 73);
            this.panel2.TabIndex = 9;
            // 
            // panel_tool
            // 
            this.panel_tool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_tool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_tool.Location = new System.Drawing.Point(0, 70);
            this.panel_tool.Name = "panel_tool";
            this.panel_tool.Size = new System.Drawing.Size(847, 3);
            this.panel_tool.TabIndex = 49;
            // 
            // btn_Remove_KhachHang
            // 
            this.btn_Remove_KhachHang.BackColor = System.Drawing.Color.White;
            this.btn_Remove_KhachHang.FlatAppearance.BorderSize = 0;
            this.btn_Remove_KhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove_KhachHang.Location = new System.Drawing.Point(729, 19);
            this.btn_Remove_KhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Remove_KhachHang.Name = "btn_Remove_KhachHang";
            this.btn_Remove_KhachHang.Size = new System.Drawing.Size(95, 34);
            this.btn_Remove_KhachHang.TabIndex = 3;
            this.btn_Remove_KhachHang.Text = "Remove";
            this.btn_Remove_KhachHang.UseVisualStyleBackColor = false;
            // 
            // btn_Edit_KhachHang
            // 
            this.btn_Edit_KhachHang.BackColor = System.Drawing.Color.White;
            this.btn_Edit_KhachHang.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Edit_KhachHang.FlatAppearance.BorderSize = 0;
            this.btn_Edit_KhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Edit_KhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Edit_KhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit_KhachHang.Location = new System.Drawing.Point(630, 19);
            this.btn_Edit_KhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Edit_KhachHang.Name = "btn_Edit_KhachHang";
            this.btn_Edit_KhachHang.Size = new System.Drawing.Size(95, 34);
            this.btn_Edit_KhachHang.TabIndex = 2;
            this.btn_Edit_KhachHang.Text = "Edit";
            this.btn_Edit_KhachHang.UseVisualStyleBackColor = false;
            // 
            // btn_Add_KhachHang
            // 
            this.btn_Add_KhachHang.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Add_KhachHang.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Add_KhachHang.FlatAppearance.BorderSize = 0;
            this.btn_Add_KhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Add_KhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Add_KhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_KhachHang.ForeColor = System.Drawing.Color.White;
            this.btn_Add_KhachHang.Location = new System.Drawing.Point(508, 19);
            this.btn_Add_KhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Add_KhachHang.Name = "btn_Add_KhachHang";
            this.btn_Add_KhachHang.Size = new System.Drawing.Size(118, 34);
            this.btn_Add_KhachHang.TabIndex = 1;
            this.btn_Add_KhachHang.Text = "Add New";
            this.btn_Add_KhachHang.UseVisualStyleBackColor = false;
            this.btn_Add_KhachHang.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách Hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Search_KhachHang);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 62);
            this.panel1.TabIndex = 11;
            // 
            // btn_Search_KhachHang
            // 
            this.btn_Search_KhachHang.BackColor = System.Drawing.Color.White;
            this.btn_Search_KhachHang.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Search_KhachHang.FlatAppearance.BorderSize = 0;
            this.btn_Search_KhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Search_KhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Search_KhachHang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_KhachHang.Location = new System.Drawing.Point(288, 10);
            this.btn_Search_KhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Search_KhachHang.Name = "btn_Search_KhachHang";
            this.btn_Search_KhachHang.Size = new System.Drawing.Size(95, 34);
            this.btn_Search_KhachHang.TabIndex = 50;
            this.btn_Search_KhachHang.Text = "Search";
            this.btn_Search_KhachHang.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(18, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Nhập thông tin khách hàng...";
            // 
            // dataGV_KhachHang
            // 
            this.dataGV_KhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dataGV_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_KhachHang.Location = new System.Drawing.Point(4, 142);
            this.dataGV_KhachHang.Name = "dataGV_KhachHang";
            this.dataGV_KhachHang.Size = new System.Drawing.Size(840, 388);
            this.dataGV_KhachHang.TabIndex = 12;
            // 
            // UC_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGV_KhachHang);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UC_KhachHang";
            this.Size = new System.Drawing.Size(847, 542);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_KhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_tool;
        private System.Windows.Forms.Button btn_Remove_KhachHang;
        private System.Windows.Forms.Button btn_Edit_KhachHang;
        private System.Windows.Forms.Button btn_Add_KhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Search_KhachHang;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGV_KhachHang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
