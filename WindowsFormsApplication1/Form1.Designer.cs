namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAviónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarInformaciónDeAvionesDeUnTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarInformaciónDeAvionesDeDestinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAvionesConMenosVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarCantidadTotalDePasajerosPorOrigenYDestinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAviónToolStripMenuItem,
            this.registrarVueloToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            this.registrosToolStripMenuItem.Click += new System.EventHandler(this.registrosToolStripMenuItem_Click);
            // 
            // registrarAviónToolStripMenuItem
            // 
            this.registrarAviónToolStripMenuItem.Name = "registrarAviónToolStripMenuItem";
            this.registrarAviónToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.registrarAviónToolStripMenuItem.Text = "Registrar Avión";
            this.registrarAviónToolStripMenuItem.Click += new System.EventHandler(this.registrarAviónToolStripMenuItem_Click);
            // 
            // registrarVueloToolStripMenuItem
            // 
            this.registrarVueloToolStripMenuItem.Name = "registrarVueloToolStripMenuItem";
            this.registrarVueloToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.registrarVueloToolStripMenuItem.Text = "Registrar Vuelo";
            this.registrarVueloToolStripMenuItem.Click += new System.EventHandler(this.registrarVueloToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarInformaciónDeAvionesDeUnTipoToolStripMenuItem,
            this.listarInformaciónDeAvionesDeDestinoToolStripMenuItem,
            this.listarAvionesConMenosVuelosToolStripMenuItem,
            this.listarCantidadTotalDePasajerosPorOrigenYDestinoToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // listarInformaciónDeAvionesDeUnTipoToolStripMenuItem
            // 
            this.listarInformaciónDeAvionesDeUnTipoToolStripMenuItem.Name = "listarInformaciónDeAvionesDeUnTipoToolStripMenuItem";
            this.listarInformaciónDeAvionesDeUnTipoToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.listarInformaciónDeAvionesDeUnTipoToolStripMenuItem.Text = "Listar Información de Aviones de un Tipo";
            this.listarInformaciónDeAvionesDeUnTipoToolStripMenuItem.Click += new System.EventHandler(this.listarInformaciónDeAvionesDeUnTipoToolStripMenuItem_Click);
            // 
            // listarInformaciónDeAvionesDeDestinoToolStripMenuItem
            // 
            this.listarInformaciónDeAvionesDeDestinoToolStripMenuItem.Name = "listarInformaciónDeAvionesDeDestinoToolStripMenuItem";
            this.listarInformaciónDeAvionesDeDestinoToolStripMenuItem.Size = new System.Drawing.Size(295, 22);
            this.listarInformaciónDeAvionesDeDestinoToolStripMenuItem.Text = "Listar Información de Aviones por Destino";
            this.listarInformaciónDeAvionesDeDestinoToolStripMenuItem.Click += new System.EventHandler(this.listarInformaciónDeAvionesDeDestinoToolStripMenuItem_Click);
            // 
            // listarAvionesConMenosVuelosToolStripMenuItem
            // 
            this.listarAvionesConMenosVuelosToolStripMenuItem.Name = "listarAvionesConMenosVuelosToolStripMenuItem";
            this.listarAvionesConMenosVuelosToolStripMenuItem.Size = new System.Drawing.Size(312, 22);
            this.listarAvionesConMenosVuelosToolStripMenuItem.Text = "Listar Aviones con menos cantidad de Vuelos";
            this.listarAvionesConMenosVuelosToolStripMenuItem.Click += new System.EventHandler(this.listarAvionesConMenosVuelosToolStripMenuItem_Click);
            // 
            // listarCantidadTotalDePasajerosPorOrigenYDestinoToolStripMenuItem
            // 
            this.listarCantidadTotalDePasajerosPorOrigenYDestinoToolStripMenuItem.Name = "listarCantidadTotalDePasajerosPorOrigenYDestinoToolStripMenuItem";
            this.listarCantidadTotalDePasajerosPorOrigenYDestinoToolStripMenuItem.Size = new System.Drawing.Size(363, 22);
            this.listarCantidadTotalDePasajerosPorOrigenYDestinoToolStripMenuItem.Text = "Listar Cantidad Total de Pasajeros por Origen y Destino";
            this.listarCantidadTotalDePasajerosPorOrigenYDestinoToolStripMenuItem.Click += new System.EventHandler(this.listarCantidadTotalDePasajerosPorOrigenYDestinoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAviónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarInformaciónDeAvionesDeUnTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarInformaciónDeAvionesDeDestinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAvionesConMenosVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarCantidadTotalDePasajerosPorOrigenYDestinoToolStripMenuItem;
    }
}

