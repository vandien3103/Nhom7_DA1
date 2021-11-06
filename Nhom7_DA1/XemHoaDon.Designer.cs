
namespace WindowsFormsApp1
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
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.dgvCT_HoaDon = new System.Windows.Forms.DataGridView();
            this.btnXemHD = new System.Windows.Forms.Button();
            this.btnXemCTHD = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_HoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMaHD
            // 
            this.tbMaHD.Location = new System.Drawing.Point(139, 24);
            this.tbMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(171, 22);
            this.tbMaHD.TabIndex = 5;
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.Location = new System.Drawing.Point(10, 24);
            this.lbMaHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(121, 24);
            this.lbMaHD.TabIndex = 6;
            this.lbMaHD.Text = "Nhập MaHD";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(15, 88);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(599, 247);
            this.dgvHoaDon.TabIndex = 7;
            // 
            // dgvCT_HoaDon
            // 
            this.dgvCT_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_HoaDon.Location = new System.Drawing.Point(663, 136);
            this.dgvCT_HoaDon.Name = "dgvCT_HoaDon";
            this.dgvCT_HoaDon.RowHeadersWidth = 51;
            this.dgvCT_HoaDon.RowTemplate.Height = 24;
            this.dgvCT_HoaDon.Size = new System.Drawing.Size(862, 247);
            this.dgvCT_HoaDon.TabIndex = 8;
            // 
            // btnXemHD
            // 
            this.btnXemHD.Location = new System.Drawing.Point(455, 355);
            this.btnXemHD.Name = "btnXemHD";
            this.btnXemHD.Size = new System.Drawing.Size(159, 47);
            this.btnXemHD.TabIndex = 9;
            this.btnXemHD.Text = "Xem Hóa Đơn";
            this.btnXemHD.UseVisualStyleBackColor = true;
            this.btnXemHD.Click += new System.EventHandler(this.btnXemHD_Click);
            // 
            // btnXemCTHD
            // 
            this.btnXemCTHD.Location = new System.Drawing.Point(1366, 403);
            this.btnXemCTHD.Name = "btnXemCTHD";
            this.btnXemCTHD.Size = new System.Drawing.Size(159, 47);
            this.btnXemCTHD.TabIndex = 10;
            this.btnXemCTHD.Text = "Xem CT Hóa Đơn";
            this.btnXemCTHD.UseVisualStyleBackColor = true;
            this.btnXemCTHD.Click += new System.EventHandler(this.btnXemCTHD_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBackToMenu.Location = new System.Drawing.Point(1425, 489);
            this.btnBackToMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(100, 41);
            this.btnBackToMenu.TabIndex = 11;
            this.btnBackToMenu.Text = "Back";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cú pháp \'HD\' + \'số thứ tự\'. Ví dụ: HD1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnXemHD);
            this.groupBox1.Controls.Add(this.dgvHoaDon);
            this.groupBox1.Controls.Add(this.lbMaHD);
            this.groupBox1.Controls.Add(this.tbMaHD);
            this.groupBox1.Location = new System.Drawing.Point(22, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1529, 432);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // XemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 543);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnXemCTHD);
            this.Controls.Add(this.dgvCT_HoaDon);
            this.Controls.Add(this.groupBox1);
            this.Name = "XemHoaDon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XemHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.XemHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_HoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridView dgvCT_HoaDon;
        private System.Windows.Forms.Button btnXemHD;
        private System.Windows.Forms.Button btnXemCTHD;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

