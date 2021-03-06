
namespace Nhom7_DA1
{
    partial class ThemHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemHoaDon));
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaoBang = new System.Windows.Forms.Button();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.tbtongtien = new System.Windows.Forms.TextBox();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.lbtongtien = new System.Windows.Forms.Label();
            this.lbngaylap = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(530, 273);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 31);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpNgayLap);
            this.groupBox1.Controls.Add(this.tbtongtien);
            this.groupBox1.Controls.Add(this.tbMaKH);
            this.groupBox1.Controls.Add(this.tbMaHD);
            this.groupBox1.Controls.Add(this.lbtongtien);
            this.groupBox1.Controls.Add(this.lbngaylap);
            this.groupBox1.Controls.Add(this.lbMaKH);
            this.groupBox1.Controls.Add(this.lbMaHD);
            this.groupBox1.Location = new System.Drawing.Point(43, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 210);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mặc định bằng 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nhập ngày trong khoảng: 5/2020 - 6/2021";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cú pháp \'KH\' + \'số thứ tự\'. Ví dụ: KH1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cú pháp \'HD\' + \'số thứ tự\'. Ví dụ: HD1";
            // 
            // btnTaoBang
            // 
            this.btnTaoBang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTaoBang.Location = new System.Drawing.Point(43, 273);
            this.btnTaoBang.Name = "btnTaoBang";
            this.btnTaoBang.Size = new System.Drawing.Size(56, 31);
            this.btnTaoBang.TabIndex = 8;
            this.btnTaoBang.Text = "Tạo";
            this.btnTaoBang.UseVisualStyleBackColor = false;
            this.btnTaoBang.Click += new System.EventHandler(this.btnTaoBang_Click);
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(141, 117);
            this.dtpNgayLap.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtpNgayLap.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(105, 20);
            this.dtpNgayLap.TabIndex = 7;
            this.dtpNgayLap.Value = new System.DateTime(2021, 3, 31, 0, 0, 0, 0);
            // 
            // tbtongtien
            // 
            this.tbtongtien.Location = new System.Drawing.Point(141, 153);
            this.tbtongtien.Name = "tbtongtien";
            this.tbtongtien.Size = new System.Drawing.Size(129, 20);
            this.tbtongtien.TabIndex = 6;
            this.tbtongtien.Text = "0";
            // 
            // tbMaKH
            // 
            this.tbMaKH.Location = new System.Drawing.Point(141, 77);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(129, 20);
            this.tbMaKH.TabIndex = 5;
            // 
            // tbMaHD
            // 
            this.tbMaHD.Location = new System.Drawing.Point(141, 38);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(129, 20);
            this.tbMaHD.TabIndex = 4;
            // 
            // lbtongtien
            // 
            this.lbtongtien.AutoSize = true;
            this.lbtongtien.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtongtien.Location = new System.Drawing.Point(36, 153);
            this.lbtongtien.Name = "lbtongtien";
            this.lbtongtien.Size = new System.Drawing.Size(85, 21);
            this.lbtongtien.TabIndex = 3;
            this.lbtongtien.Text = "Tổng tiền";
            // 
            // lbngaylap
            // 
            this.lbngaylap.AutoSize = true;
            this.lbngaylap.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbngaylap.Location = new System.Drawing.Point(36, 116);
            this.lbngaylap.Name = "lbngaylap";
            this.lbngaylap.Size = new System.Drawing.Size(85, 21);
            this.lbngaylap.TabIndex = 2;
            this.lbngaylap.Text = "Ngày Lập";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.Location = new System.Drawing.Point(36, 77);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(56, 21);
            this.lbMaKH.TabIndex = 1;
            this.lbMaKH.Text = "MaKH";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.Location = new System.Drawing.Point(36, 35);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(58, 21);
            this.lbMaHD.TabIndex = 0;
            this.lbMaHD.Text = "MaHD";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(646, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hoToolStripMenuItem
            // 
            this.hoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hoToolStripMenuItem.Image")));
            this.hoToolStripMenuItem.Name = "hoToolStripMenuItem";
            this.hoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.hoToolStripMenuItem.Text = "Home";
            this.hoToolStripMenuItem.Click += new System.EventHandler(this.hoToolStripMenuItem_Click);
            // 
            // ThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 336);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnTaoBang);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ThemHoaDon";
            this.Text = "ThemHoaDon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThemHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.ThemHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaoBang;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox tbtongtien;
        private System.Windows.Forms.TextBox tbMaKH;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.Label lbtongtien;
        private System.Windows.Forms.Label lbngaylap;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hoToolStripMenuItem;
    }
}