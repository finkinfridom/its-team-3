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

        public Prenotazione()
        {
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
            ric.programs[0] = checkBox1.Checked;
            ric.programs[1] = checkBox2.Checked;
            ric.programs[2] = checkBox3.Checked;
            ric.programs[3] = checkBox4.Checked;
            ric.programs[4] = checkBox5.Checked;
            ric.programs[5] = checkBox6.Checked;
            ric.programs[6] = checkBox7.Checked;
            ric.programs[7] = checkBox8.Checked;
            ric.programs[8] = checkBox9.Checked;
            ric.programs[9] = checkBox10.Checked;
            ric.programs[10] = checkBox11.Checked;
            ric.programs[11] = checkBox12.Checked;

            ric.cerca();
        }

        private void Prenotazione_Load(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
