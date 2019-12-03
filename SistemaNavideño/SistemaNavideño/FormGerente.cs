using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNavideño
{
    public partial class FormGerente : Form
    {
        public FormGerente()
        {
            InitializeComponent();
        }

        private void yOtroCasoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGEmpleados fg = new FormGEmpleados();
            fg.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
