using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace MiniSQLDerleyicisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=THINKPAD-E470;Initial Catalog=DBNotKayıt;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            string sorgu = richTextBox1.Text;
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {

                MessageBox.Show("Sorgunuzu lütfen kontrol edin ! ","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;
            try
            {
                
                conn.Open();
                SqlCommand komut = new SqlCommand(sorgu, conn);
                komut.ExecuteNonQuery();
                conn.Close();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLDERS", conn); //tabloların son halini görmek için böyle yaptık
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorgunuzu Kontrol ediniz.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;
            try
            {
                conn.Open();
                SqlCommand komut = new SqlCommand(sorgu, conn);
                komut.ExecuteNonQuery();
                conn.Close();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLDERS", conn); //tabloların son halini görmek için böyle yaptık
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorgunuzu Kontrol ediniz.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;
            try
            {
                
                conn.Open();
                SqlCommand komut = new SqlCommand(sorgu, conn);
                komut.ExecuteNonQuery();
                conn.Close();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TBLDERS", conn); //tabloların son halini görmek için böyle yaptık
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorgunuzu Kontrol ediniz.");
            }
        }
    }
}
