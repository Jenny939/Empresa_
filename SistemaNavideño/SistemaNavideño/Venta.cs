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
        double tot = 0;
        public Venta()
        {
            InitializeComponent();
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tarjetaVentaDataSet.Catálogo' Puede moverla o quitarla según sea necesario.
            this.catálogoTableAdapter.Fill(this.tarjetaVentaDataSet.Catálogo);
            // TODO: esta línea de código carga datos en la tabla 'tarjetaVentaDataSet._Cliente_Empresa' Puede moverla o quitarla según sea necesario.
            this.cliente_EmpresaTableAdapter.Fill(this.tarjetaVentaDataSet._Cliente_Empresa);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
