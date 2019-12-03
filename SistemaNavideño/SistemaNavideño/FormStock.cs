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
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        private void stockBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stockBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tarjetaVentaDataSet);

        }

        private void FormStock_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tarjetaVentaDataSet.Stock' Puede moverla o quitarla según sea necesario.
            this.stockTableAdapter.Fill(this.tarjetaVentaDataSet.Stock);

        }
    }
}
