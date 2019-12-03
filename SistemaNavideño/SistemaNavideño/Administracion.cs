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
    public partial class Administracion : Form
    {
        public Administracion()
        {
            InitializeComponent();
        }

        private void listaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            cod_EmpleadoTextBox.Visible = true;
            cod_EmpleadoLabel.Visible = true;
            cILabel.Visible = true;
            nombreLabel.Visible = true;
            apellidoLabel.Visible = true;
            cargoLabel.Visible = true;
            nombreTextBox.Visible = true;
            apellidoTextBox.Visible = true;
            cargoTextBox.Visible = true;
            cITextBox.Visible = true;
            empleadoDataGridView.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            empleadoTableAdapter.Fill(tarjetaVentaDataSet.Empleado);
        }

        private void empleadoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tarjetaVentaDataSet);

        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tarjetaVentaDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.tarjetaVentaDataSet.Empleado);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cod_EmpleadoTextBox.Clear();
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            cITextBox.Clear();
            cargoTextBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            empleadoTableAdapter.Insert(Convert.ToInt32(cod_EmpleadoTextBox.Text), Convert.ToInt32(cITextBox.Text), nombreTextBox.Text, apellidoTextBox.Text, cargoTextBox.Text);
            empleadoTableAdapter.Fill(tarjetaVentaDataSet.Empleado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            empleadoTableAdapter.modificar(Convert.ToInt32(cITextBox.Text), nombreTextBox.Text, apellidoTextBox.Text, cargoTextBox.Text,Convert.ToInt32(cod_EmpleadoTextBox.Text));
            empleadoTableAdapter.Fill(tarjetaVentaDataSet.Empleado);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            empleadoTableAdapter.eliminar(Convert.ToInt32(cod_EmpleadoTextBox.Text));
            empleadoTableAdapter.Fill(tarjetaVentaDataSet.Empleado);
        }
    }
}
