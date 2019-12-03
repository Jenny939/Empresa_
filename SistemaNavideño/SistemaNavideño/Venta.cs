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
    public partial class Venta : Form
    {
        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tarjetaVentaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.tarjetaVentaDataSet.Ventas);
            // TODO: esta línea de código carga datos en la tabla 'tarjetaVentaDataSet.Detalle_Venta' Puede moverla o quitarla según sea necesario.
            this.detalle_VentaTableAdapter.Fill(this.tarjetaVentaDataSet.Detalle_Venta);
            // TODO: esta línea de código carga datos en la tabla 'tarjetaVentaDataSet.Catálogo' Puede moverla o quitarla según sea necesario.
            this.catálogoTableAdapter.Fill(this.tarjetaVentaDataSet.Catálogo);
            // TODO: esta línea de código carga datos en la tabla 'tarjetaVentaDataSet._Cliente_Empresa' Puede moverla o quitarla según sea necesario.
            this.cliente_EmpresaTableAdapter.Fill(this.tarjetaVentaDataSet._Cliente_Empresa);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int can, subto, tot;
            int id = int.Parse(textBox6.Text);
            
            tot = int.Parse(textBox2.Text);
            can = int.Parse(textBox4.Text);
            subto = int.Parse(textBox3.Text);
            tot = tot + can * subto;
            textBox2.Text = tot.ToString();
            detalle_VentaTableAdapter.Insert(id,can,subto);
            detalle_VentaTableAdapter.Fill(tarjetaVentaDataSet.Detalle_Venta);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tot;
            int idemp = int.Parse(textBox5.Text);
            DateTime n = DateTime.Parse(textBox1.Text);
            tot = int.Parse(textBox2.Text);
            ventasTableAdapter.Insert(idemp, tot.ToString(), n);
            ventasTableAdapter.Fill(tarjetaVentaDataSet.Ventas);
            MessageBox.Show("Venta Terminada");
            this.Close();
        }
    }
}
