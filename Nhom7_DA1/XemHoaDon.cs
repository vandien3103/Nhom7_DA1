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

namespace WindowsFormsApp1
{
    public partial class XemHoaDon : Form
    {
        public XemHoaDon()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        private void XemHoaDon_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["DoAn1"].ConnectionString.ToString();
            cnn = new SqlConnection(conString);
            cnn.Open();
        }
        private void XemHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            cnn.Close();
        }

        public bool checkMaHD()
        {
            string sqlcheckmahd = "select * from HoaDon Where MaHD = '" + tbMaHD.Text + "'";
            SqlCommand cmdcheckmahd = new SqlCommand();
            cmdcheckmahd.CommandText = sqlcheckmahd;
            cmdcheckmahd.Connection = cnn;
            SqlDataReader mahd = cmdcheckmahd.ExecuteReader();

            string valueMaHD = tbMaHD.Text;
            int lenHD = valueMaHD.Length;
            if (mahd.Read() == false)
            {
                MessageBox.Show("Mã hóa đơn không đúng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaHD.Focus();
                return false;
            }
            mahd.Close();
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
            return true;
        }
        private void btnXemHD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMaHD.Text))
            {
                string sqlHoaDon = "select * from HoaDon";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sqlHoaDon;
                cmd.Connection = cnn;

                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgvHoaDon.DataSource = dt;
                dr.Close();
            }
            else
            {
                if (checkMaHD() == true)
                {
                    string sqlHoaDonmahd = "select * from HoaDon Where MaHD = '" + tbMaHD.Text + "'";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = sqlHoaDonmahd;
                    cmd.Connection = cnn;

                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dgvHoaDon.DataSource = dt;
                    dr.Close();
                }
            }
        }

        private void btnXemCTHD_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbMaHD.Text))
            {
                MessageBox.Show("Bạn chưa nhập MaKH", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbMaHD.Focus();
            }
            else
            {
                if(checkMaHD() == true)
                {
                    string sqlCTHoaDon = "select * from CT_HoaDon where MaHD = '" + tbMaHD.Text + "'";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = sqlCTHoaDon;
                    cmd.Connection = cnn;

                    SqlDataReader dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dgvCT_HoaDon.DataSource = dt;
                    dr.Close();
                }    
            }
        }


        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Activate();
            mn.Show();
            this.Hide();
        }
    }
}
