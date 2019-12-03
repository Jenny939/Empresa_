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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tarjetaVentaDataSet.Pedido' Puede moverla o quitarla según sea necesario.
            this.pedidoTableAdapter.Fill(this.tarjetaVentaDataSet.Pedido);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pedidoTableAdapter.Insert(Convert.ToInt32(textBox1.Text), Convert.ToDateTime(textBox2.Text), Convert.ToInt32(textBox3.Text),Convert.ToInt32(textBox4.Text));
            pedidoTableAdapter.Fill(tarjetaVentaDataSet.Pedido);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pedidoTableAdapter.modificar(Convert.ToInt32(textBox1.Text), Convert.ToDateTime(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox1.Text));
            pedidoTableAdapter.Fill(tarjetaVentaDataSet.Pedido);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pedidoTableAdapter.eliminar(Convert.ToInt32(textBox1.Text));
            pedidoTableAdapter.Fill(tarjetaVentaDataSet.Pedido);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

    }
}
