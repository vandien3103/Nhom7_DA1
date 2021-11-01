
namespace Nhom7_DA1
{
    partial class DoanhThu
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
            this.tbNhap = new System.Windows.Forms.TextBox();
            this.xem = new System.Windows.Forms.Button();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNhap
            // 
            this.tbNhap.Location = new System.Drawing.Point(81, 58);
            this.tbNhap.Name = "tbNhap";
            this.tbNhap.Size = new System.Drawing.Size(197, 20);
            this.tbNhap.TabIndex = 0;
            // 
            // xem
            // 
            this.xem.Location = new System.Drawing.Point(81, 132);
            this.xem.Name = "xem";
            this.xem.Size = new System.Drawing.Size(75, 23);
            this.xem.TabIndex = 1;
            this.xem.Text = "btnXem";
            this.xem.UseVisualStyleBackColor = true;
            this.xem.Click += new System.EventHandler(this.xem_Click);
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Location = new System.Drawing.Point(364, 58);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.Size = new System.Drawing.Size(329, 219);
            this.dgvDoanhThu.TabIndex = 2;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.xem);
            this.Controls.Add(this.tbNhap);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoanhThu_FormClosing);
            this.Load += new System.EventHandler(this.DoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNhap;
        private System.Windows.Forms.Button xem;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
    }
}