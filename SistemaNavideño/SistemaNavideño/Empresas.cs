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
            /*('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "','" + textBox5.Text + "', '"+ textBox6.Text +"')";
            cliente_EmpresaTableAdapter.Insert((int IdEmp, 
            MessageBox.Show("Registrado exitosamente!");*/
        }

        private void Empresas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tarjetaVentaDataSet._Cliente_Empresa' Puede moverla o quitarla según sea necesario.
            this.cliente_EmpresaTableAdapter.Fill(this.tarjetaVentaDataSet._Cliente_Empresa);

        }
    }
}
