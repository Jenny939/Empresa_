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
            this.yOtroCasoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeCatálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservaDePedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otroCasoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yOtroCasoToolStripMenuItem,
            this.otroCasoToolStripMenuItem,
            this.listaClientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
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
            // otroCasoToolStripMenuItem
            // 
            this.otroCasoToolStripMenuItem.Name = "otroCasoToolStripMenuItem";
            this.otroCasoToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.otroCasoToolStripMenuItem.Text = "Realizar Venta";
            this.otroCasoToolStripMenuItem.Click += new System.EventHandler(this.otroCasoToolStripMenuItem_Click);
            // 
            // listaClientesToolStripMenuItem
            // 
            this.listaClientesToolStripMenuItem.Name = "listaClientesToolStripMenuItem";
            this.listaClientesToolStripMenuItem.Size = new System.Drawing.Size(190, 20);
            this.listaClientesToolStripMenuItem.Text = "Lista Clientes Potenciales";
            this.listaClientesToolStripMenuItem.Click += new System.EventHandler(this.listaClientesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(407, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(122, 84);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(171, 242);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(142, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(761, 446);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormEmpleado";
            this.Text = "FormEmpleado";
            this.Load += new System.EventHandler(this.FormEmpleado_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
    }
}