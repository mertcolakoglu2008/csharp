using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Data.SqlClient;

namespace girisKayit
{
    public partial class Form5 : Form
    {
        static SqlConnection baglanti = new SqlConnection(@"Data source=OMER\SQLEXPRESS; initial catalog=KisiBilgi; integrated security=true");

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        SqlConnection connection;
        SqlDataReader dr;
        SqlCommand cmd;

        public static string GuvenlikSorusu;
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data source=OMER\SQLEXPRESS; initial catalog=KisiBilgi; integrated security=true");
            cmd = new SqlCommand();
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandText = "Select*From KisiBilgiler Where Eposta= '" + textBox1.Text + "' And GuvenlikSorusu = '" + textBox2.Text + "'";
            dr = cmd.ExecuteReader();
            GuvenlikSorusu = textBox2.Text;
            if (dr.Read())
            {
                Form6 form6 = new Form6();
                form6.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş başarısız bilgilerinizi tekrar kontrol ediniz");
            }
        }
    }
}
