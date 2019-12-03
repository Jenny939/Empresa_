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
    public partial class Empresas : Form
    {
        public Empresas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente_EmpresaTableAdapter.Insert(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text), textBox6.Text);
            cliente_EmpresaTableAdapter.Fill(tarjetaVentaDataSet._Cliente_Empresa);
        }

        private void Empresas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tarjetaVentaDataSet._Cliente_Empresa' Puede moverla o quitarla según sea necesario.
            this.cliente_EmpresaTableAdapter.Fill(this.tarjetaVentaDataSet._Cliente_Empresa);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cliente_EmpresaTableAdapter.modificar(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text), textBox6.Text,Convert.ToInt32(textBox1.Text));
            cliente_EmpresaTableAdapter.Fill(tarjetaVentaDataSet._Cliente_Empresa);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cliente_EmpresaTableAdapter.eliminar(Convert.ToInt32(textBox1.Text));
            cliente_EmpresaTableAdapter.Fill(tarjetaVentaDataSet._Cliente_Empresa);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

        }

    }
}
