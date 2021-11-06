
namespace Nhom7_DA1
{
    partial class XemHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XemHoaDon));
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.btnXemCTHD = new System.Windows.Forms.Button();
            this.dgvCT_HoaDon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXemHD = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_HoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBackToMenu.Location = new System.Drawing.Point(1047, 397);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(75, 33);
            this.btnBackToMenu.TabIndex = 24;
            this.btnBackToMenu.Text = "Back";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // btnXemCTHD
            // 
            this.btnXemCTHD.Location = new System.Drawing.Point(464, 288);
            this.btnXemCTHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXemCTHD.Name = "btnXemCTHD";
            this.btnXemCTHD.Size = new System.Drawing.Size(119, 38);
            this.btnXemCTHD.TabIndex = 23;
            this.btnXemCTHD.Text = "Xem CT Hóa Đơn";
            this.btnXemCTHD.UseVisualStyleBackColor = true;
            this.btnXemCTHD.Click += new System.EventHandler(this.btnXemCTHD_Click);
            // 
            // dgvCT_HoaDon
            // 
            this.dgvCT_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_HoaDon.Location = new System.Drawing.Point(464, 72);
            this.dgvCT_HoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCT_HoaDon.Name = "dgvCT_HoaDon";
            this.dgvCT_HoaDon.RowHeadersWidth = 51;
            this.dgvCT_HoaDon.RowTemplate.Height = 24;
            this.dgvCT_HoaDon.Size = new System.Drawing.Size(646, 201);
            this.dgvCT_HoaDon.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnXemHD);
            this.groupBox1.Controls.Add(this.btnXemCTHD);
            this.groupBox1.Controls.Add(this.dgvHoaDon);
            this.groupBox1.Controls.Add(this.dgvCT_HoaDon);
            this.groupBox1.Controls.Add(this.lbMaHD);
            this.groupBox1.Controls.Add(this.tbMaHD);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1147, 351);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cú pháp \'HD\' + \'số thứ tự\'. Ví dụ: HD1";
            // 
            // btnXemHD
            // 
            this.btnXemHD.Location = new System.Drawing.Point(12, 288);
            this.btnXemHD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXemHD.Name = "btnXemHD";
            this.btnXemHD.Size = new System.Drawing.Size(119, 38);
            this.btnXemHD.TabIndex = 9;
            this.btnXemHD.Text = "Xem Hóa Đơn";
            this.btnXemHD.UseVisualStyleBackColor = true;
            this.btnXemHD.Click += new System.EventHandler(this.btnXemHD_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(11, 72);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(449, 201);
            this.dgvHoaDon.TabIndex = 7;
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.Location = new System.Drawing.Point(8, 20);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(100, 19);
            this.lbMaHD.TabIndex = 6;
            this.lbMaHD.Text = "Nhập MaHD";
            // 
            // tbMaHD
            // 
            this.tbMaHD.Location = new System.Drawing.Point(113, 20);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(137, 20);
            this.tbMaHD.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1145, 28);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hoToolStripMenuItem
            // 
            this.hoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hoToolStripMenuItem.Image")));
            this.hoToolStripMenuItem.Name = "hoToolStripMenuItem";
            this.hoToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.hoToolStripMenuItem.Text = "Home";
            this.hoToolStripMenuItem.Click += new System.EventHandler(this.hoToolStripMenuItem_Click);
            // 
            // XemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 442);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "XemHoaDon";
            this.Text = "XemHoaDon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XemHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.XemHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_HoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Button btnXemCTHD;
        private System.Windows.Forms.DataGridView dgvCT_HoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXemHD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hoToolStripMenuItem;
    }
}