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
using System.Configuration;

namespace Nhom7_DA1
{
    public partial class ThemHoaDon : Form
    {
        public ThemHoaDon()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        private void ThemHoaDon_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["DoAn1"].ConnectionString.ToString();
            cnn = new SqlConnection(conString);
            cnn.Open();
        }
        private void ThemHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            cnn.Close();
        }
        public bool checkdata()
        {
            string sqlcheckmahd = "select * from HoaDon Where MaHD = '" + tbMaHD.Text + "'";
            SqlCommand cmdcheckmahd = new SqlCommand();
            cmdcheckmahd.CommandText = sqlcheckmahd;
            cmdcheckmahd.Connection = cnn;
            SqlDataReader mahd = cmdcheckmahd.ExecuteReader();
            if (string.IsNullOrWhiteSpace(tbMaHD.Text))
            {
                MessageBox.Show("Bạn chưa nhập MaHD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaHD.Focus();
                return false;
            }
            if (mahd.Read() == true)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaHD.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbMaKH.Text))
            {
                MessageBox.Show("Bạn chưa nhập MaKH", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaKH.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbtongtien.Text))
            {
                MessageBox.Show("Bạn chưa nhập TongTien", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbtongtien.Focus();
                return false;
            }
            return true;
        }
        private void btnTaoBang_Click(object sender, EventArgs e)
        {
            if (checkdata() == true)
            {
                string sqlInsert = "insert into HoaDon values(@MaHD, @MaKH, @NgayLap, @TongTien)";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sqlInsert;
                cmd.Connection = cnn;
                cmd.Parameters.AddWithValue("MaHD", tbMaHD.Text);
                cmd.Parameters.AddWithValue("MaKH", tbMaKH.Text);
                cmd.Parameters.AddWithValue("NgayLap", dtpNgayLap.Text);
                cmd.Parameters.AddWithValue("TongTien", tbtongtien.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tạo hóa đơn thành công");
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Activate();
            mn.Show();
            this.Hide();
        }
    }
}
