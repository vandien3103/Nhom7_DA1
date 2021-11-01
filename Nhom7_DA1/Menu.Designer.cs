
namespace Nhom7_DA1
{
    partial class Menu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_doanhthu = new System.Windows.Forms.Button();
            this.btn_xemdshoadon = new System.Windows.Forms.Button();
            this.btn_themhoadon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(18, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(744, 409);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.btn_doanhthu);
            this.groupBox2.Controls.Add(this.btn_xemdshoadon);
            this.groupBox2.Controls.Add(this.btn_themhoadon);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(31, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(686, 351);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // btn_doanhthu
            // 
            this.btn_doanhthu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_doanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doanhthu.Location = new System.Drawing.Point(498, 235);
            this.btn_doanhthu.Name = "btn_doanhthu";
            this.btn_doanhthu.Size = new System.Drawing.Size(145, 49);
            this.btn_doanhthu.TabIndex = 9;
            this.btn_doanhthu.Text = "Doanh thu";
            this.btn_doanhthu.UseVisualStyleBackColor = false;
            this.btn_doanhthu.Click += new System.EventHandler(this.btn_doanhthu_Click);
            // 
            // btn_xemdshoadon
            // 
            this.btn_xemdshoadon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_xemdshoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemdshoadon.Location = new System.Drawing.Point(232, 235);
            this.btn_xemdshoadon.Name = "btn_xemdshoadon";
            this.btn_xemdshoadon.Size = new System.Drawing.Size(214, 49);
            this.btn_xemdshoadon.TabIndex = 8;
            this.btn_xemdshoadon.Text = "Xem danh sách hóa đơn";
            this.btn_xemdshoadon.UseVisualStyleBackColor = false;
            // 
            // btn_themhoadon
            // 
            this.btn_themhoadon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_themhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themhoadon.Location = new System.Drawing.Point(32, 235);
            this.btn_themhoadon.Name = "btn_themhoadon";
            this.btn_themhoadon.Size = new System.Drawing.Size(145, 49);
            this.btn_themhoadon.TabIndex = 7;
            this.btn_themhoadon.Text = "Thêm hóa đơn";
            this.btn_themhoadon.UseVisualStyleBackColor = false;
            this.btn_themhoadon.Click += new System.EventHandler(this.btn_themhoadon_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vui lòng chọn chức năng muốn thực hiện!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(178, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Bán Hàng";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 431);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_doanhthu;
        private System.Windows.Forms.Button btn_xemdshoadon;
        private System.Windows.Forms.Button btn_themhoadon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

