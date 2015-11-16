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

namespace Mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fill_btn_Click(object sender, EventArgs e)
        {
            user_txtbox.Text = "team.net.sou@gmail.com";
            pass_txtbox.Text = "network336";
        }

        private void fill2_btn_Click(object sender, EventArgs e)
        {
            to_txtbox.Text = "ikenamik@sou.edu";
        }

        private void fill3_btn_Click(object sender, EventArgs e)
        {
            to_txtbox.Text = "zhengy1@sou.edu";
        }
        private void send_btn_Click(object sender, EventArgs e)
        {

            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.Credentials = new NetworkCredential(user_txtbox.Text, pass_txtbox.Text);

                MailMessage msg = new MailMessage();
                msg.To.Add(new MailAddress(to_txtbox.Text));
                msg.From = new MailAddress(user_txtbox.Text);
                msg.Subject = subj_txtbox.Text;
                msg.Body = cont_txtbox.Text;
                client.EnableSsl = true;
                client.Send(msg);

                MessageBox.Show("Mail Sent!");
            }
            catch
            {
                MessageBox.Show("Sorry, please check your Login credentials.", "ERROR!");
            }
        }

        private void rst_btn_Click(object sender, EventArgs e)
        {
            user_txtbox.Text = String.Empty;
            pass_txtbox.Text = String.Empty;
            to_txtbox.Text = String.Empty;
            from_txtbox.Text = String.Empty;
            subj_txtbox.Text = String.Empty;
            cont_txtbox.Text = String.Empty;
        }

        private void user_txtbox_TextChanged(object sender, EventArgs e)
        {
            from_txtbox.Text = user_txtbox.Text;
        }
        
    }
}
