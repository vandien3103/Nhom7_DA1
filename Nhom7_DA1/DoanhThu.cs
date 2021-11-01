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
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
        }
        SqlConnection cnn;

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["DoAn1"].ConnectionString.ToString();
            cnn = new SqlConnection(conString);
            cnn.Open();
        }

        private void DoanhThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            cnn.Close();
        }

        private void xem_Click(object sender, EventArgs e)
        {
            string sqlDoanhThu = "select * from KhachHang ";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sqlDoanhThu;
            cmd.Connection = cnn;

            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgvDoanhThu.DataSource = dt;
        }

    }
}
