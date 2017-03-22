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
using System.Data.SqlTypes;
using System.Configuration;
using System.Net.Mail;
using System.Net;

namespace classbooking
{
    public partial class Registrazione : Form
    {
        public Registrazione()
        {
            InitializeComponent();
        }

        private void esci_Click(object sender, EventArgs e) { Close(); }

        private void invia_Click(object sender, EventArgs e)
        {
            string mail = insertEmail.Text;
            string ps = insertPassword.Text;

            if (!EmailAddress.isValidEmail(insertEmail.Text))
            {
                insertEmail.BackColor = Color.Red;
                MessageBox.Show("Inserisci una e-mail valida");
            }
            else if (!Password.isValidPassword(insertPassword.Text))
            {
                insertPassword.BackColor = Color.Red;
                MessageBox.Show("Password non valida. Deve contenere almeno 8 caratteri di cui almeno una lettera minuscola, una lettera maiuscola e un numero.");
            }
            else if (insertPassword.Text != ConfermaPassword.Text)
            {
                MessageBox.Show("Password Inserita nel campor di conferma Errata \nConfermare la password");
                ConfermaPassword.Clear();
            }
            else
            {
                insertEmail.BackColor = Color.White;
                insertPassword.BackColor = Color.White;

                using (SqlConnection conn = new SqlConnection())
                {

                    conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
                    conn.Open();
                    string select = "select email from [utente] where email=?";
                    using (SqlCommand cmd = new SqlCommand(select, conn))
                    {
                        cmd.Parameters.Add(new SqlParameter("@email", insertEmail.Text));
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                MessageBox.Show("E-mail già registrata", "ERROR", MessageBoxButtons.OK);
                            }
                        }
                    }

                    string password = Crypto.crypto(insertPassword.Text);
                    string email = Crypto.crypto(insertEmail.Text);
                    string str = "insert into [Utente] (nome,cognome,email,password) values ('" + insertNome.Text + "','" + insertCognome.Text + "','" + email + "','" + password + "')";

                    using (SqlCommand cmd = new SqlCommand(str, conn))
                    {
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registrazione riuscita");
                    }
                    conn.Close();
                }
            }
            Prenotazione pren = new Prenotazione(insertEmail.Text);

            try
            {
                MailMessage message = new MailMessage();
                using (SmtpClient smtp = new SmtpClient())
                {

                    message.From = new MailAddress("prenotaule@virgilio.it");
                    message.To.Add(new MailAddress(mail));
                    message.Subject = "Registrazione  Prenotazione Aula";
                    message.Body = "Benvenuto\r\n" + insertCognome.Text + " " + insertNome.Text + "\r\nTi sei registrato con successo al nostro servizio di prenota aule, ecco le tue credenziali \r\nEMAIL:" + mail + "\r\nPASSWORD:" + ps;
                    smtp.Port = 587;
                    smtp.Host = "smtp.virgilio.it";
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("prenotaule@virgilio.it", "prenotaaule");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                    smtp.Send(message);
                }
            }
            catch (HttpListenerException ex)
            {

                MessageBox.Show("err: " + ex.Message);
            }
            this.Close();
            pren.Show();
        }


        private void Registrazione_Load(object sender, EventArgs e) { }
        private void insertPassword_TextChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
    }
}   
