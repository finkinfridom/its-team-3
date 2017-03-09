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

        private void esci_Click(object sender, EventArgs e) { Close(); }

        private void invia_Click(object sender, EventArgs e)
        {
            if (Verifiche.verificaEmail(insertEmail.Text) && Verifiche.verificaPassword(insertPassword.Text))
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
                try
                {
                    string mail = insertEmail.Text;
                    string password = Crypto.crypto(insertPassword.Text);
                    string email = Crypto.crypto(insertEmail.Text);
                    string str = "insert into [Utente] (nome,cognome,email,password) values ('" + insertNome.Text + "','" + insertCognome.Text + "','" + email + "','" + password + "')";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(str, conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {   
                    throw;
                }
    
                conn.Close();
                MessageBox.Show("Registrazione riuscita");
                Login lg = new Login(/*insertEmail.Text,insertPassword.Text*/);
                this.Hide();
                lg.Show();

            }
            else if(!Verifiche.verificaEmail(insertEmail.Text))
            {
                insertEmail.BackColor = Color.Red;
                MessageBox.Show("Inserisci una e-mail valida");
            }
            else if (!Verifiche.verificaPassword(insertPassword.Text))
            {
                insertPassword.BackColor = Color.Red;
                MessageBox.Show("Password non valida. Deve contenere almeno una lettera un numero e un simbolo.");
            }
            insertEmail.BackColor = Color.White;
            insertPassword.BackColor = Color.White;
        }

        private void Registrazione_Load(object sender, EventArgs e) { }
        private void insertPassword_TextChanged(object sender, EventArgs e) {  }
    }
}   
