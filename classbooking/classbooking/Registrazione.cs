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
            if (insertPassword.TextLength > 4)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DataBase\basedati.mdf;Integrated Security=True;Connect Timeout=30");
                string str = "insert into [Utente] (nome,cognome,email,password) values ('" + insertNome.Text + "','" + insertCognome.Text + "','" + insertEmail.Text + "','" + insertPassword.Text + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
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
    }
}   
