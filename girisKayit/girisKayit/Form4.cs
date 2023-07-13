using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace girisKayit
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        public void button1_Click(object sender, EventArgs e)
        {
            MailMessage mesaj = new MailMessage();
            SmtpClient istemci= new SmtpClient();
            istemci.Credentials = new System.Net.NetworkCredential("omertcolakoglu2008@gmail.com", "a16b19c16");
            istemci.Port = 587;
            istemci.Host = "smtp.google.com";
            istemci.EnableSsl = true;
            mesaj.To.Add(textBox1.Text);
            mesaj.From = new MailAddress("omertcolakoglu2008@gmail.com");
            mesaj.Subject = "Şifre işlemleri";
            mesaj.Body = "Doğrulama kodunuz : 6514981346";
            istemci.Send(mesaj);
            MessageBox.Show("Mail gönderildi mailinize gelen kodu girip şifrenizi değiştirin");
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "6514981346")
            {
                Form form5 = new Form();
                form5.Show();
                this.Hide();
            }
        }
    }
}
