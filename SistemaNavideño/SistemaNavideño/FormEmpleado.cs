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
            Listado l = new Listado();
            l.ShowDialog();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void registroDeEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empresas emp = new Empresas();
            emp.ShowDialog();
        }

        private void registroDeCatálogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catalogos cat = new Catalogos();
            cat.ShowDialog();
        }

        private void reservaDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos ped = new Pedidos();
            ped.ShowDialog();
        }
    }
}
