using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace classbooking
{
    public partial class Registrazione_effettuata : Form
    {
        private string email;
        public Registrazione_effettuata(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void Registrazione_effettuata_Load(object sender, EventArgs e)
        {

            label1.Text = email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress("prenotaule@virgilio.it");
                message.To.Add(new MailAddress(textemail.Text));
                message.Subject = "Conferma Prenotazione Aula";
                message.Body = "Benvenuto" + textemail.Text + " Confermiamo la tua prenotazione ecco il codice ...........";

                smtp.Port = 587;
                smtp.Host = "smtp.virgilio.it";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("prenotaule@virgilio.it", "prenotaaule");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.Send(message);

            }
            catch (Exception ex)
            {
                MessageBox.Show("err: " + ex.Message);
            }

        }

        private void Registrazione_effettuata_Load_1(object sender, EventArgs e)
        {

        }
    }
}
