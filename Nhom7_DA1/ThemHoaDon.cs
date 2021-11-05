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
            // check cú pháp MaHD

            string valueMaHD = tbMaHD.Text;
            int lenHD = valueMaHD.Length;

            if (string.IsNullOrWhiteSpace(tbMaHD.Text))
            {
                MessageBox.Show("Bạn chưa nhập MaHD", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaHD.Focus();
                return false;
            }
            if (lenHD <= 2)
            {
                MessageBox.Show("Nhập sai cú pháp. Cú pháp: HD + 'số thứ tự' ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaHD.Focus();
                return false;
            }
            if (valueMaHD[lenHD - 1] != '0' && valueMaHD[lenHD - 1] != '1' && valueMaHD[lenHD - 1] != '2' && valueMaHD[lenHD - 1] != '3' && valueMaHD[lenHD - 1] != '4' && valueMaHD[lenHD - 1] != '5' && valueMaHD[lenHD - 1] != '6' && valueMaHD[lenHD - 1] != '7' && valueMaHD[lenHD - 1] != '8' && valueMaHD[lenHD - 1] != '9')
            {
                MessageBox.Show("Nhập sai cú pháp. Cú pháp: HD + 'số thứ tự'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaHD.Focus();
                return false;
            }
            if (valueMaHD.Substring(0, 2) != "HD")
            {
                MessageBox.Show("Nhập sai cú pháp. Cú pháp: HD + 'số thứ tự'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaHD.Focus();
                return false;
            }
            string sqlcheckmahd = "select * from HoaDon Where MaHD = '" + tbMaHD.Text + "'";
            SqlCommand cmdcheckmahd = new SqlCommand();
            cmdcheckmahd.CommandText = sqlcheckmahd;
            cmdcheckmahd.Connection = cnn;
            SqlDataReader mahd = cmdcheckmahd.ExecuteReader();
            if (mahd.Read() == true)
            {
                MessageBox.Show("Mã hóa đơn đã tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaHD.Focus();
                return false;
            }
            mahd.Close();
            // check cú pháp MaKH
            string valueMaKH = tbMaKH.Text;
            int lenKH = valueMaKH.Length;
            if (string.IsNullOrWhiteSpace(tbMaKH.Text))
            {
                MessageBox.Show("Bạn chưa nhập MaKH", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaKH.Focus();
                return false;
            }
            if (lenKH <= 2)
            {
                MessageBox.Show("Nhập sai cú pháp. Cú pháp: KH + 'số thứ tự'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaKH.Focus();
                return false;
            }
            if (valueMaKH[lenKH - 1] != '0' && valueMaKH[lenKH - 1] != '1' && valueMaKH[lenKH - 1] != '2' && valueMaKH[lenKH - 1] != '3' && valueMaKH[lenKH - 1] != '4' && valueMaKH[lenKH - 1] != '5' && valueMaKH[lenKH - 1] != '6' && valueMaKH[lenKH - 1] != '7' && valueMaKH[lenKH - 1] != '8' && valueMaKH[lenKH - 1] != '9')
            {
                MessageBox.Show("Nhập sai cú pháp. Cú pháp: KH + 'số thứ tự'", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaKH.Focus();
                return false;
            }
            if (valueMaKH.Substring(0, 2) != "KH")
            {
                MessageBox.Show("Nhập sai cú pháp. Cú pháp: KH + 'số thứ tự' ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaKH.Focus();
                return false;
            }
            string sqlcheckmakh = "select * from HoaDon Where MaKH = '" + tbMaKH.Text + "'";
            SqlCommand cmdcheckmakh = new SqlCommand();
            cmdcheckmakh.CommandText = sqlcheckmakh;
            cmdcheckmakh.Connection = cnn;
            SqlDataReader makh = cmdcheckmakh.ExecuteReader();
            if (makh.Read() == false)
            {
                MessageBox.Show("Mã khách hàng không tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaKH.Focus();
                return false;
            }
            makh.Close();
            // check cú pháp NgayLap
            DateTime ngay = dtpNgayLap.Value;
            if ((ngay.Month < 5 && ngay.Year <= 2020) || (ngay.Month > 6 && ngay.Year >= 2021))
            {
                MessageBox.Show("Nhập sai cú pháp. Nhập ngày trong khoảng: 5/2020 - 6/2021", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNgayLap.Focus();
                return false;
            }

            // check cú pháp Tổng tiền
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
                cmd.Parameters.AddWithValue("NgayLap", dtpNgayLap.Value);
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
        private void hoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Activate();
            mn.Show();
            this.Hide();
        }
    }
}
