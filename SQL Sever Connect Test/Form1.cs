using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Sever_Connect_Test
{
    public partial class Form1 : Form
    {
        private SqlConnection cnn;
        public Form1()
        {
            InitializeComponent();
            cnn = new SqlConnection(@"Data Source=LAPTOP-RV1BP0SH\SQLEXPRESS;Initial Catalog=ThucHanh2_QLKH;Integrated Security=true");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_InsertCustomer", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Thay đổi kiểu dữ liệu tùy theo kiểu dữ liệu của cột trong bảng KhachHang
                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = int.Parse(txtID.Text);
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 30)).Value = txtName.Text;
                    cmd.Parameters.Add(new SqlParameter("@address", SqlDbType.NVarChar, 40)).Value = txtAddress.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Stored procedure đã được gọi và dữ liệu đã được thêm vào bảng KhachHang.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi kết nối đến SQL Server: " + ex.Message);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("usp_Customer", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridKH1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("usp_TongTien", cnn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridThanhTien.DataSource = dt;
            }
        }
    }
}
