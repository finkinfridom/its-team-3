using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo2
{
    public partial class Dopolog : Form
    {
        public Dopolog(string nome)
        {
            InitializeComponent();
            label1.Text = nome;
        }

        private void Dopolog_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Luigi qui va il calendario");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
