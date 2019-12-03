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
    public partial class Catalogos : Form
    {
        public Catalogos()
        {
            InitializeComponent();
        }

        private void Catalogos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tarjetaVentaDataSet.Catálogo' Puede moverla o quitarla según sea necesario.
            this.catálogoTableAdapter.Fill(this.tarjetaVentaDataSet.Catálogo);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            catálogoTableAdapter.Insert(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text));
            catálogoTableAdapter.Fill(tarjetaVentaDataSet.Catálogo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            catálogoTableAdapter.modificar(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox1.Text));
            catálogoTableAdapter.Fill(tarjetaVentaDataSet.Catálogo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            catálogoTableAdapter.eliminar(Convert.ToInt32(textBox1.Text));
            catálogoTableAdapter.Fill(tarjetaVentaDataSet.Catálogo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }


    }
}
