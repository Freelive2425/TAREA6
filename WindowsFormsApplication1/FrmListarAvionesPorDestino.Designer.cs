namespace WindowsFormsApplication1
{
    partial class FrmListarAvionesPorDestino
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBDestino = new System.Windows.Forms.ComboBox();
            this.lBcodigo = new System.Windows.Forms.ListBox();
            this.lBtipo = new System.Windows.Forms.ListBox();
            this.lBcapacidad = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudad de Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aviones(código)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidad";
            // 
            // cBDestino
            // 
            this.cBDestino.FormattingEnabled = true;
            this.cBDestino.Items.AddRange(new object[] {
            "Lima",
            "Bogotá",
            "Panamá",
            "Brasil"});
            this.cBDestino.Location = new System.Drawing.Point(156, 16);
            this.cBDestino.Name = "cBDestino";
            this.cBDestino.Size = new System.Drawing.Size(160, 21);
            this.cBDestino.TabIndex = 4;
            this.cBDestino.SelectedIndexChanged += new System.EventHandler(this.cBDestino_SelectedIndexChanged);
            // 
            // lBcodigo
            // 
            this.lBcodigo.FormattingEnabled = true;
            this.lBcodigo.Location = new System.Drawing.Point(12, 122);
            this.lBcodigo.Name = "lBcodigo";
            this.lBcodigo.Size = new System.Drawing.Size(120, 121);
            this.lBcodigo.TabIndex = 5;
            // 
            // lBtipo
            // 
            this.lBtipo.FormattingEnabled = true;
            this.lBtipo.Location = new System.Drawing.Point(156, 122);
            this.lBtipo.Name = "lBtipo";
            this.lBtipo.Size = new System.Drawing.Size(120, 121);
            this.lBtipo.TabIndex = 6;
            // 
            // lBcapacidad
            // 
            this.lBcapacidad.FormattingEnabled = true;
            this.lBcapacidad.Location = new System.Drawing.Point(315, 122);
            this.lBcapacidad.Name = "lBcapacidad";
            this.lBcapacidad.Size = new System.Drawing.Size(120, 121);
            this.lBcapacidad.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(198, 268);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 27);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmListarAvionesPorDestino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 316);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lBcapacidad);
            this.Controls.Add(this.lBtipo);
            this.Controls.Add(this.lBcodigo);
            this.Controls.Add(this.cBDestino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmListarAvionesPorDestino";
            this.Text = "FrmListarAvionesPorDestino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBDestino;
        private System.Windows.Forms.ListBox lBcodigo;
        private System.Windows.Forms.ListBox lBtipo;
        private System.Windows.Forms.ListBox lBcapacidad;
        private System.Windows.Forms.Button btnSalir;
    }
}