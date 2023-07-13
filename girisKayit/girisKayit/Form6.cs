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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace girisKayit
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        static SqlConnection baglanti = new SqlConnection(@"Data source=OMER\SQLEXPRESS; initial catalog=KisiBilgi; integrated security=true");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("update KisiBilgiler set Sifre=@sifre Where GuvenlikSorusu=@gSorusu" , baglanti);
            cmd.Parameters.AddWithValue("@sifre" , textBox1.Text);
            cmd.Parameters.AddWithValue("@gSorusu" , Form5.GuvenlikSorusu);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şifreniz başarıyla değiştirildi şimdi giriş yapabilirsiniz");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';

        }
    }
}
