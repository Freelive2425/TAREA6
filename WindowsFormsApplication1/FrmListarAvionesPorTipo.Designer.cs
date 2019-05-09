namespace WindowsFormsApplication1
{
    partial class FrmListarAvionesPorTipo
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
            this.lBAviones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBTipoAvion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCapacidad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBAviones
            // 
            this.lBAviones.FormattingEnabled = true;
            this.lBAviones.Location = new System.Drawing.Point(78, 125);
            this.lBAviones.Name = "lBAviones";
            this.lBAviones.Size = new System.Drawing.Size(120, 173);
            this.lBAviones.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de avión";
            // 
            // cBTipoAvion
            // 
            this.cBTipoAvion.FormattingEnabled = true;
            this.cBTipoAvion.Items.AddRange(new object[] {
            "Boeing 737",
            "Airbus A-310",
            "Boeing 747",
            "Airbus A-320"});
            this.cBTipoAvion.Location = new System.Drawing.Point(116, 30);
            this.cBTipoAvion.Name = "cBTipoAvion";
            this.cBTipoAvion.Size = new System.Drawing.Size(121, 21);
            this.cBTipoAvion.TabIndex = 2;
            this.cBTipoAvion.SelectedIndexChanged += new System.EventHandler(this.cBTipoAvion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Capacidad";
            // 
            // lbCapacidad
            // 
            this.lbCapacidad.AutoSize = true;
            this.lbCapacidad.Location = new System.Drawing.Point(125, 70);
            this.lbCapacidad.Name = "lbCapacidad";
            this.lbCapacidad.Size = new System.Drawing.Size(0, 13);
            this.lbCapacidad.TabIndex = 4;
            this.lbCapacidad.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Aviones(Código)";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(92, 321);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 34);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmListarAvionesPorTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 367);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbCapacidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBTipoAvion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBAviones);
            this.Name = "FrmListarAvionesPorTipo";
            this.Text = "FrmListarAvionesPorTipo";
            this.Load += new System.EventHandler(this.FrmListarAvionesPorTipo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBAviones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBTipoAvion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCapacidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalir;
    }
}