﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Utente\Desktop\ITS\.NET C#\its-team-3-master\Database\tony.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter lgl = new SqlDataAdapter("select * from [Table] where email='" + insertEmail.Text + "'and password='" + insertPass.Text + "'", conn);
            DataTable dt = new DataTable();

            lgl.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                //Dopolog fd = new Dopolog(dt.Rows[0][0].ToString());
                //fd.Show();
            }
            else
            {
                MessageBox.Show("Inserire E-mail o Password corretta");
                insertEmail.Clear();
                insertPass.Clear();
            }
        }
    }
}
