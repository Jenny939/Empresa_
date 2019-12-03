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
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TarjetaVentaDataSet._Cliente_Empresa' Puede moverla o quitarla según sea necesario.
            this.cliente_EmpresaTableAdapter.Mostrar(this.TarjetaVentaDataSet._Cliente_Empresa);
            // TODO: esta línea de código carga datos en la tabla 'TarjetaVentaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
            this.VentasTableAdapter.Fill(this.TarjetaVentaDataSet.Ventas);
        }
    }
}
