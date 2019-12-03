namespace SistemaNavideño
{
    partial class FormEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleado));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otroCasoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yOtroCasoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.registroDeEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeCatálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaClientesToolStripMenuItem,
            this.otroCasoToolStripMenuItem,
            this.yOtroCasoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listaClientesToolStripMenuItem
            // 
            this.listaClientesToolStripMenuItem.Name = "listaClientesToolStripMenuItem";
            this.listaClientesToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.listaClientesToolStripMenuItem.Text = "Lista Clientes";
            // 
            // otroCasoToolStripMenuItem
            // 
            this.otroCasoToolStripMenuItem.Name = "otroCasoToolStripMenuItem";
            this.otroCasoToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.otroCasoToolStripMenuItem.Text = "Realizar Venta";
            this.otroCasoToolStripMenuItem.Click += new System.EventHandler(this.otroCasoToolStripMenuItem_Click);
            // 
            // yOtroCasoToolStripMenuItem
            // 
            this.yOtroCasoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeEmpresasToolStripMenuItem,
            this.registroDeCatálogosToolStripMenuItem,
            this.reservaDePedidosToolStripMenuItem});
            this.yOtroCasoToolStripMenuItem.Name = "yOtroCasoToolStripMenuItem";
            this.yOtroCasoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.yOtroCasoToolStripMenuItem.Text = "Registros";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, -47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // registroDeEmpresasToolStripMenuItem
            // 
            this.registroDeEmpresasToolStripMenuItem.Name = "registroDeEmpresasToolStripMenuItem";
            this.registroDeEmpresasToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.registroDeEmpresasToolStripMenuItem.Text = "Registro de Empresas";
            // 
            // registroDeCatálogosToolStripMenuItem
            // 
            this.registroDeCatálogosToolStripMenuItem.Name = "registroDeCatálogosToolStripMenuItem";
            this.registroDeCatálogosToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.registroDeCatálogosToolStripMenuItem.Text = "Registro de Catálogos";
            // 
            // reservaDePedidosToolStripMenuItem
            // 
            this.reservaDePedidosToolStripMenuItem.Name = "reservaDePedidosToolStripMenuItem";
            this.reservaDePedidosToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.reservaDePedidosToolStripMenuItem.Text = "Reserva de Pedidos";
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(632, 370);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormEmpleado";
            this.Text = "FormEmpleado";
            this.Load += new System.EventHandler(this.FormEmpleado_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otroCasoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yOtroCasoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem registroDeEmpresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeCatálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservaDePedidosToolStripMenuItem;
    }
}