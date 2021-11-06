using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Nhom7_DA1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void btn_themhoadon_Click_1(object sender, EventArgs e)
        {
            ThemHoaDon thd = new ThemHoaDon();
            thd.Activate();
            thd.Show();
            this.Hide();
        }

        private void btn_doanhthu_Click(object sender, EventArgs e)
        {
            DoanhThu dt = new DoanhThu();
            dt.Activate();
            dt.Show();
            this.Hide();
        }

        private void btn_xemdshoadon_Click(object sender, EventArgs e)
        {
            XemHoaDon xemhd = new XemHoaDon();
            xemhd.Activate();
            xemhd.Show();
            this.Hide();
        }
    }
}
