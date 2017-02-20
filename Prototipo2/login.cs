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


namespace Prototipo2
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\favat\Documents\tony.mdf;Integrated Security=True;Connect Timeout=30");
         
            SqlDataAdapter lgl  =new SqlDataAdapter("select * from [Table] where email='"+textBox3.Text+"'and password='"+textBox2.Text+"'",conn);
            DataTable dt = new DataTable();
          

            lgl.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                
                this.Hide();
            
                
                Dopolog fd = new Dopolog(dt.Rows[0][0].ToString());
                fd.Show();
               
            }
            else
            {
                MessageBox.Show("Inserire E-mail o Password corretta");
                textBox3.Clear();
                textBox2.Clear();
            }

            
            
         
               
        }
            
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 reg = new Form1();
            reg.Show();
        }

        
    }
}
