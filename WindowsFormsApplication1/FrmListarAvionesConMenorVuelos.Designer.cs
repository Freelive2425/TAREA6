namespace WindowsFormsApplication1
{
    partial class FrmListarAvionesConMenorVuelos
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
            this.lBcapacidad = new System.Windows.Forms.ListBox();
            this.lBtipo = new System.Windows.Forms.ListBox();
            this.lBcodigo = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBcapacidad
            // 
            this.lBcapacidad.FormattingEnabled = true;
            this.lBcapacidad.Location = new System.Drawing.Point(323, 49);
            this.lBcapacidad.Name = "lBcapacidad";
            this.lBcapacidad.Size = new System.Drawing.Size(120, 147);
            this.lBcapacidad.TabIndex = 13;
            // 
            // lBtipo
            // 
            this.lBtipo.FormattingEnabled = true;
            this.lBtipo.Location = new System.Drawing.Point(164, 49);
            this.lBtipo.Name = "lBtipo";
            this.lBtipo.Size = new System.Drawing.Size(120, 147);
            this.lBtipo.TabIndex = 12;
            // 
            // lBcodigo
            // 
            this.lBcodigo.FormattingEnabled = true;
            this.lBcodigo.Location = new System.Drawing.Point(20, 49);
            this.lBcodigo.Name = "lBcodigo";
            this.lBcodigo.Size = new System.Drawing.Size(120, 147);
            this.lBcodigo.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Capacidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Aviones(código)";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(193, 227);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmListarAvionesConMenorVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 262);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lBcapacidad);
            this.Controls.Add(this.lBtipo);
            this.Controls.Add(this.lBcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmListarAvionesConMenorVuelos";
            this.Text = "FrmListarAvionesConMenorVuelos";
            this.Load += new System.EventHandler(this.FrmListarAvionesConMenorVuelos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBcapacidad;
        private System.Windows.Forms.ListBox lBtipo;
        private System.Windows.Forms.ListBox lBcodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
    }
}