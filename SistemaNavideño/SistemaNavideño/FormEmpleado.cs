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
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void otroCasoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta v = new Venta();
            v.ShowDialog();

        }

        private void listaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
