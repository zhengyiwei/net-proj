using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.Credentials = new NetworkCredential(Form1.tb.Text, Form1.tb1.Text);

                MailMessage msg = new MailMessage();
                msg.To.Add(new MailAddress(textBox1.Text));
                msg.From = new MailAddress(Form1.usermail);
                msg.Subject = textBox3.Text;
                msg.Body = textBox4.Text;
                client.EnableSsl = true;
                client.Send(msg);

                MessageBox.Show("Mail Sent!");
            }
            catch
            {
                MessageBox.Show("Sorry, please check your Login credentials.", "ERROR!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = button1.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = button10.Text;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = button9.Text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            textBox2.Text = Form1.usermail;
        }
    }
}
