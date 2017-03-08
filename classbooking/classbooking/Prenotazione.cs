using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classbooking
{
    public partial class Prenotazione : Form
    {
        Ricerca ric = new Ricerca();
        private string email;

        public Prenotazione(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            //MessageBox.Show(e.Start.ToShortDateString());
            //e.Start.GetDateTimeFormats();
            ric.setdate(e.Start.Date);
        }

        private void Cerca_Click(object sender, EventArgs e)
        {
            ric.programmi[0] = checkBox1.Checked;
            ric.programmi[1] = checkBox2.Checked;
            ric.programmi[2] = checkBox3.Checked;
            ric.programmi[3] = checkBox4.Checked;
            ric.programmi[4] = checkBox5.Checked;
            ric.programmi[5] = checkBox6.Checked;
            ric.programmi[6] = checkBox7.Checked;
            ric.programmi[7] = checkBox8.Checked;
            ric.programmi[8] = checkBox9.Checked;
            ric.programmi[9] = checkBox10.Checked;
            ric.programmi[10] = checkBox11.Checked;
            ric.programmi[11] = checkBox12.Checked;

            ric.cerca();
            
        }

        private void Prenotazione_Load(object sender, EventArgs e)
        {
            label1.Text = email;
        }

        //private void Prenotazione_Load(object sender, EventArgs e) { }
        private void checkBox7_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox10_CheckedChanged(object sender, EventArgs e) { }
    }
}
