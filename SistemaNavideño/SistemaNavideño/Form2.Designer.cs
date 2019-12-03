namespace SistemaNavideño
{
    partial class Administracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administracion));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listaClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otroCasoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yOtroCasoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nCasoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(337, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaClientesToolStripMenuItem,
            this.otroCasoToolStripMenuItem,
            this.yOtroCasoToolStripMenuItem,
            this.nCasoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 2;
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
            this.otroCasoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.otroCasoToolStripMenuItem.Text = "Otro Caso";
            // 
            // yOtroCasoToolStripMenuItem
            // 
            this.yOtroCasoToolStripMenuItem.Name = "yOtroCasoToolStripMenuItem";
            this.yOtroCasoToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.yOtroCasoToolStripMenuItem.Text = "y Otro Caso";
            // 
            // nCasoToolStripMenuItem
            // 
            this.nCasoToolStripMenuItem.Name = "nCasoToolStripMenuItem";
            this.nCasoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.nCasoToolStripMenuItem.Text = "N caso";
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(674, 397);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Administracion";
            this.Text = "Adminsitración";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem listaClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otroCasoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yOtroCasoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nCasoToolStripMenuItem;
    }
}