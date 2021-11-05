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

            DateTime ngaynhap = dtpNgayLap.Value;
            DateTime date1 = new DateTime(2020, 5, 1);
            DateTime date2 = new DateTime(2021, 6, 30);
            int resutl1 = DateTime.Compare(ngaynhap, date1);
            int resutl2 = DateTime.Compare(ngaynhap, date2);

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
            if (resutl1 == -1 && resutl2 == 1)
            {
                MessageBox.Show("Bạn chọn ngày sai, vui lòng chọn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtpNgayLap.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tbtongtien.Text))
            {
                MessageBox.Show("Bạn chưa nhập TongTien", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbtongtien.Focus();
                return false;
            }
            mahd.Close();
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
            //string sqlInsert = "insert into HoaDon values(@MaHD, @MaKH, @NgayLap, @TongTien)";
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = sqlInsert;
            //cmd.Connection = cnn;
            //cmd.Parameters.AddWithValue("MaHD", tbMaHD.Text);
            //cmd.Parameters.AddWithValue("MaKH", tbMaKH.Text);
            //cmd.Parameters.AddWithValue("NgayLap", dtpNgayLap.Value);
            //cmd.Parameters.AddWithValue("TongTien", tbtongtien.Text);
            //cmd.ExecuteReader();
            //MessageBox.Show("Tạo hóa đơn thành công");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Activate();
            mn.Show();
            this.Hide();
        }

        private void tbMaHD_TextChanged(object sender, EventArgs e)
        {
            string value = tbMaHD.Text;
            int len = value.Length;
            if (tbMaHD.Text == "H" || tbMaHD.Text == "HD")
            {
            }
            else
            if (len <= 2)
            {
                MessageBox.Show("Cú pháp: HD + 'số thứ tự' ");
                tbMaHD.Clear();
            }
            else
                if (value[len - 1] != '0' && value[len - 1] != '1' && value[len - 1] != '2' && value[len - 1] != '3' && value[len - 1] != '4' && value[len - 1] != '5' && value[len - 1] != '6' && value[len - 1] != '7' && value[len - 1] != '8' && value[len - 1] != '9')
            {
                MessageBox.Show("Cú pháp: HD + 'số thứ tự' ");
                tbMaHD.Clear();
            }
        }

        private void tbMaKH_TextChanged(object sender, EventArgs e)
        {
            string value = tbMaKH.Text;
            int len = value.Length;
            if (tbMaKH.Text == "K" || tbMaKH.Text == "KH")
            {
            }
            else
            if (len <= 2)
            {
                MessageBox.Show("Cú pháp: KH + 'số thứ tự' ");
                tbMaKH.Clear();
            }
            else
                if (value[len - 1] != '0' && value[len - 1] != '1' && value[len - 1] != '2' && value[len - 1] != '3' && value[len - 1] != '4' && value[len - 1] != '5' && value[len - 1] != '6' && value[len - 1] != '7' && value[len - 1] != '8' && value[len - 1] != '9')
            {
                MessageBox.Show("Cú pháp: KH + 'số thứ tự' ");
                tbMaKH.Clear();
            }
        }

        private void dtpNgayLap_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngay = dtpNgayLap.Value;
            
            if ((ngay.Month<5 && ngay.Year<=2020)||(ngay.Month>6 && ngay.Year>=2021))
            {
                MessageBox.Show("Nhập ngày trong khoảng: 5/2020 - 6/2021");
                dtpNgayLap.Refresh();
            }    
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
