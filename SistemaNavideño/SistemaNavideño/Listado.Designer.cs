namespace SistemaNavideño
{
    partial class Listado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TarjetaVentaDataSet = new SistemaNavideño.TarjetaVentaDataSet();
            this.VentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VentasTableAdapter = new SistemaNavideño.TarjetaVentaDataSetTableAdapters.VentasTableAdapter();
            this.cliente_EmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cliente_EmpresaTableAdapter = new SistemaNavideño.TarjetaVentaDataSetTableAdapters.Cliente_EmpresaTableAdapter();
            this.tableAdapterManager = new SistemaNavideño.TarjetaVentaDataSetTableAdapters.TableAdapterManager();
            this.cliente_EmpresaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TarjetaVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_EmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_EmpresaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TarjetaVentaDataSet
            // 
            this.TarjetaVentaDataSet.DataSetName = "TarjetaVentaDataSet";
            this.TarjetaVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VentasBindingSource
            // 
            this.VentasBindingSource.DataMember = "Ventas";
            this.VentasBindingSource.DataSource = this.TarjetaVentaDataSet;
            // 
            // VentasTableAdapter
            // 
            this.VentasTableAdapter.ClearBeforeFill = true;
            // 
            // cliente_EmpresaBindingSource
            // 
            this.cliente_EmpresaBindingSource.DataMember = "Cliente/Empresa";
            this.cliente_EmpresaBindingSource.DataSource = this.TarjetaVentaDataSet;
            // 
            // cliente_EmpresaTableAdapter
            // 
            this.cliente_EmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CatálogoTableAdapter = null;
            this.tableAdapterManager.Cliente_EmpresaTableAdapter = this.cliente_EmpresaTableAdapter;
            this.tableAdapterManager.Detalle_pedidoTableAdapter = null;
            this.tableAdapterManager.Detalle_VentaTableAdapter = null;
            this.tableAdapterManager.EmpleadoTableAdapter = null;
            this.tableAdapterManager.PedidoTableAdapter = null;
            this.tableAdapterManager.StockTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaNavideño.TarjetaVentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentasTableAdapter = this.VentasTableAdapter;
            // 
            // cliente_EmpresaDataGridView
            // 
            this.cliente_EmpresaDataGridView.AutoGenerateColumns = false;
            this.cliente_EmpresaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cliente_EmpresaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.cliente_EmpresaDataGridView.DataSource = this.cliente_EmpresaBindingSource;
            this.cliente_EmpresaDataGridView.Location = new System.Drawing.Point(28, 43);
            this.cliente_EmpresaDataGridView.Name = "cliente_EmpresaDataGridView";
            this.cliente_EmpresaDataGridView.Size = new System.Drawing.Size(653, 230);
            this.cliente_EmpresaDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdEmp";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdEmp";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NroEmpleado";
            this.dataGridViewTextBoxColumn3.HeaderText = "NroEmpleado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Descripccion";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descripccion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PorcentajeCompra";
            this.dataGridViewTextBoxColumn5.HeaderText = "PorcentajeCompra";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Afiliado";
            this.dataGridViewTextBoxColumn6.HeaderText = "Afiliado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 317);
            this.Controls.Add(this.cliente_EmpresaDataGridView);
            this.Name = "Listado";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Listado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TarjetaVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_EmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente_EmpresaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource VentasBindingSource;
        private TarjetaVentaDataSet TarjetaVentaDataSet;
        private TarjetaVentaDataSetTableAdapters.VentasTableAdapter VentasTableAdapter;
        private System.Windows.Forms.BindingSource cliente_EmpresaBindingSource;
        private TarjetaVentaDataSetTableAdapters.Cliente_EmpresaTableAdapter cliente_EmpresaTableAdapter;
        private TarjetaVentaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView cliente_EmpresaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}