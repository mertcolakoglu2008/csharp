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

namespace girisKayit
{

    

    public partial class Form3 : Form
    {
        static SqlConnection baglanti = new SqlConnection(@"Data source=OMER\SQLEXPRESS; initial catalog=KisiBilgi; integrated security=true");

        public Form3()
        {
            InitializeComponent();
            
        }
        static bool guvenlik = false;

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if ( textBox2.Text == textBox3.Text )
            {
                baglanti.Open();
                string veriler = "insert into KisiBilgiler(Ad , Soyad , Eposta , Sifre , GuvenlikSorusu) values ('"+ textBox1.Text +"' , '"+ textBox5.Text +"' , '"+textBox4.Text+"' , '"+textBox2.Text+"' , '"+textBox6.Text+"')";

                using (SqlCommand komut = new SqlCommand(veriler, baglanti))
                    komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("uyarı!! kaydınız başarı ile tamamlanmıştır , giriş yapabilirsiniz");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';

        }
    }
}
