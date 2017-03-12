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

        public Aula()
        {
            InitializeComponent();
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

        
    }
}
