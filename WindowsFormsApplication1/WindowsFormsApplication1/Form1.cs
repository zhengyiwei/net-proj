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
    public partial class Form1 : Form
    {
        public static String usermail;
        public static SmtpClient client;
        public static TextBox tb = new TextBox();
        public static TextBox tb1 = new TextBox();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            usermail = textBox1.Text;
            form2.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb = textBox1;
            tb1 = textBox2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "team.net.sou@gmail.com";
            textBox2.Text = "network336";
        }
    }
}
