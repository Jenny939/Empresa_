namespace SistemaNavideño
{
    partial class RVentas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.VentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TarjetaVentaDataSet = new SistemaNavideño.TarjetaVentaDataSet();
            this.VentasTableAdapter = new SistemaNavideño.TarjetaVentaDataSetTableAdapters.VentasTableAdapter();
            this.ReporteVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteVentaTableAdapter = new SistemaNavideño.TarjetaVentaDataSetTableAdapters.ReporteVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.VentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TarjetaVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.VentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SistemaNavideño.ReporteVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(31, 23);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(487, 292);
            this.reportViewer1.TabIndex = 0;
            // 
            // VentasBindingSource
            // 
            this.VentasBindingSource.DataMember = "Ventas";
            this.VentasBindingSource.DataSource = this.TarjetaVentaDataSet;
            // 
            // TarjetaVentaDataSet
            // 
            this.TarjetaVentaDataSet.DataSetName = "TarjetaVentaDataSet";
            this.TarjetaVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // VentasTableAdapter
            // 
            this.VentasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteVentaBindingSource
            // 
            this.ReporteVentaBindingSource.DataMember = "ReporteVenta";
            this.ReporteVentaBindingSource.DataSource = this.TarjetaVentaDataSet;
            // 
            // ReporteVentaTableAdapter
            // 
            this.ReporteVentaTableAdapter.ClearBeforeFill = true;
            // 
            // RVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 352);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RVentas";
            this.Text = "RVentas";
            this.Load += new System.EventHandler(this.RVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TarjetaVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VentasBindingSource;
        private TarjetaVentaDataSet TarjetaVentaDataSet;
        private TarjetaVentaDataSetTableAdapters.VentasTableAdapter VentasTableAdapter;
        private System.Windows.Forms.BindingSource ReporteVentaBindingSource;
        private TarjetaVentaDataSetTableAdapters.ReporteVentaTableAdapter ReporteVentaTableAdapter;
    }
}