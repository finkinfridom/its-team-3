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
using System.Security.Cryptography;

namespace classbooking
{
    public partial class Registrazione : Form
    {
        public Registrazione()
        {
            InitializeComponent();
        }

        static string crypto(string value)
        {
            using (SHA1CryptoServiceProvider password = new SHA1CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = password.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }

        }

        private void esci_Click(object sender, EventArgs e) { Close(); }

        private void invia_Click(object sender, EventArgs e)
        {
            if (insertPassword.TextLength > 4)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
                try
                {
                    string mail = insertEmail.Text;
                    insertPassword.Text = crypto(insertPassword.Text);
                    insertEmail.Text = crypto(insertEmail.Text);
                    string str = "insert into [Utente] (nome,cognome,email,password) values ('" + insertNome.Text + "','" + insertCognome.Text + "','" + insertEmail.Text + "','" + insertPassword.Text + "')";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    conn.Open();
                    throw;
                }

                // SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DataBase\basedati.mdf;Integrated Security=True;Connect Timeout=30");
                //conn.Open();

                conn.Close();
                MessageBox.Show("Registrazione riuscita");
                Login lg = new Login();
                this.Hide();
                lg.Show();

            }
            else
            {
                MessageBox.Show("Password inserita inferiore ad 5 caratteri");
            }
        }

        private void Registrazione_Load(object sender, EventArgs e) { }
        private void insertPassword_TextChanged(object sender, EventArgs e) { }
    }
}   
