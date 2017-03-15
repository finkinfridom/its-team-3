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
    public partial class Aula : Form
    {
        bool[] orari = new Boolean[8];
        int aulaCorrente;
        List<int> aule;
        string email;

        public Aula()
        {
            InitializeComponent();
        }
        public Aula(List<int> auleTrovate, int id, string email)
        {
            InitializeComponent();
            aulaCorrente = id;
            aule = auleTrovate;
            this.email = email;
        }


        private void CercaOrario_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                orari[i] = checkedListBox1.CheckOnClick;
                MessageBox.Show(orari[1].ToString());
            }
        }
        
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e){}

        private void Aula_Load(object sender, EventArgs e)
        {
            load();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void Avanti_Click(object sender, EventArgs e)
        {
            if (aulaCorrente == 9)
                aulaCorrente = 0;
            else aulaCorrente++;
            load();
        }

        private void Indietro_Click(object sender, EventArgs e)
        {
            if (aulaCorrente == 0)
                aulaCorrente = 9;
            else aulaCorrente--;
            load();
        }

        void load()
        {
            label_nomeAula.Text = string.Concat("Aula ", aulaCorrente + 1);
        }
    }
}
