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
        List<int> lAule = new List<int>();
        private string mail;

        public Prenotazione(string mail)
        {
            this.mail = mail;
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

            lAule = ric.cerca();

            if (!ric.aule[0])
                Aula1.Hide();
            else Aula1.Show();
            if (!ric.aule[1])
                Aula2.Hide();
            else Aula2.Show();
            if (!ric.aule[2])
                Aula3.Hide();
            else Aula3.Show();
            if (!ric.aule[3])
                Aula4.Hide();
            else Aula4.Show();
            if (!ric.aule[4])
                Aula5.Hide();
            else Aula5.Show();
            if (!ric.aule[5])
                Aula6.Hide();
            else Aula6.Show();
            if (!ric.aule[6])
                Aula7.Hide();
            else Aula7.Show();
            if (!ric.aule[7])
                Aula8.Hide();
            else Aula8.Show();
            if (!ric.aule[8])
                Aula9.Hide();
            else Aula9.Show();
            if (!ric.aule[9])
                Aula10.Hide();
            else Aula10.Show();

        }

        private void Prenotazione_Load(object sender, EventArgs e)
        {
            label1.Text = mail;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void checkBox10_CheckedChanged(object sender, EventArgs e) { }

        private void Aula1_Click(object sender, EventArgs e)
        {
            nuovaAula(0);
        }
        private void Aula2_Click(object sender, EventArgs e)
        {
            nuovaAula(1);
        }
        private void Aula3_Click(object sender, EventArgs e)
        {
            nuovaAula(2);
        }
        private void Aula4_Click(object sender, EventArgs e)
        {
            nuovaAula(3);
        }
        private void Aula5_Click(object sender, EventArgs e)
        {
            nuovaAula(4);
        }
        private void Aula6_Click(object sender, EventArgs e)
        {
            nuovaAula(5);
        }
        private void Aula7_Click(object sender, EventArgs e)
        {
            nuovaAula(6);
        }
        private void Aula8_Click(object sender, EventArgs e)
        {
            nuovaAula(7);
        }
        private void Aula9_Click(object sender, EventArgs e)
        {
            nuovaAula(8);
        }
        private void Aula10_Click(object sender, EventArgs e)
        {
            nuovaAula(9);
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void nuovaAula(int id)
        {
            Hide();
            Aula aula = new Aula(lAule, id, mail);
            aula.Show();
        }
    }
}
