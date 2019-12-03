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
    public partial class RVentas : Form
    {
        public RVentas()
        {
            InitializeComponent();
        }

        private void RVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TarjetaVentaDataSet.ReporteVenta' Puede moverla o quitarla según sea necesario.
            this.ReporteVentaTableAdapter.Fill(this.TarjetaVentaDataSet.ReporteVenta);
            // TODO: esta línea de código carga datos en la tabla 'TarjetaVentaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
            this.VentasTableAdapter.Fill(this.TarjetaVentaDataSet.Ventas);

            this.reportViewer1.RefreshReport();
        }
    }
}
