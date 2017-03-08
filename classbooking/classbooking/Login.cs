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
using System.Management;
using System.Security.Cryptography;


namespace classbooking
{
    public partial class Login : Form
    {
        private string email;
        private string password;
        public Login(string email,string password)
        {
            InitializeComponent();
            this.email = email;
            this.password = password;
         
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

        private void _registrazione_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registrazione reg = new Registrazione();
            reg.Show();
        }

        private void _exit_Click(object sender, EventArgs e) { Close(); }

        private void _login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }


            //SqlConnection conn = new SqlConnection(@"connectionString['MyDBConnectionString']");

            //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\DataBase\basedati.mdf;Integrated Security=True;Connect Timeout=30");

          
            password = crypto(insertPass.Text);
            email = crypto(insertEmail.Text);

            SqlDataAdapter lgl = new SqlDataAdapter("select * from [Utente] where email='" + email + "'and password='" + password + "'", conn);
            DataTable dt = new DataTable();
            
            lgl.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                Prenotazione fd = new Prenotazione(insertEmail.Text);
                fd.Show();
            }
            else
            {
                MessageBox.Show("Inserire E-mail o Password corretta");
                insertPass.Clear();
            }
        }

        private void Login_Load(object sender, EventArgs e) { }
    }
}
