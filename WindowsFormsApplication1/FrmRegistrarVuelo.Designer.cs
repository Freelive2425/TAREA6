namespace WindowsFormsApplication1
{
    partial class FrmRegistrarVuelo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroVuelo = new System.Windows.Forms.TextBox();
            this.cBOrigen = new System.Windows.Forms.ComboBox();
            this.cBDestino = new System.Windows.Forms.ComboBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lBAviones
            // 
            this.lBAviones.FormattingEnabled = true;
            this.lBAviones.Location = new System.Drawing.Point(317, 67);
            this.lBAviones.Name = "lBAviones";
            this.lBAviones.Size = new System.Drawing.Size(120, 212);
            this.lBAviones.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de vuelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ciudad de Origen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ciudad de Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hora de vuelo";
            // 
            // txtNumeroVuelo
            // 
            this.txtNumeroVuelo.Location = new System.Drawing.Point(139, 36);
            this.txtNumeroVuelo.Name = "txtNumeroVuelo";
            this.txtNumeroVuelo.Size = new System.Drawing.Size(142, 20);
            this.txtNumeroVuelo.TabIndex = 5;
            // 
            // cBOrigen
            // 
            this.cBOrigen.FormattingEnabled = true;
            this.cBOrigen.Items.AddRange(new object[] {
            "Lima",
            "Bogotá",
            "Panamá",
            "Brasil"});
            this.cBOrigen.Location = new System.Drawing.Point(139, 78);
            this.cBOrigen.Name = "cBOrigen";
            this.cBOrigen.Size = new System.Drawing.Size(142, 21);
            this.cBOrigen.TabIndex = 6;
            // 
            // cBDestino
            // 
            this.cBDestino.FormattingEnabled = true;
            this.cBDestino.Items.AddRange(new object[] {
            "Lima",
            "Bogotá",
            "Panamá",
            "Brasil"});
            this.cBDestino.Location = new System.Drawing.Point(139, 117);
            this.cBDestino.Name = "cBDestino";
            this.cBDestino.Size = new System.Drawing.Size(142, 21);
            this.cBDestino.TabIndex = 7;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(139, 149);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(55, 20);
            this.txtHora.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aviones";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(105, 280);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(216, 280);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmRegistrarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 315);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.cBDestino);
            this.Controls.Add(this.cBOrigen);
            this.Controls.Add(this.txtNumeroVuelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBAviones);
            this.Name = "FrmRegistrarVuelo";
            this.Text = "FrmRegistrarVuelo";
            this.Load += new System.EventHandler(this.FrmRegistrarVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBAviones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumeroVuelo;
        private System.Windows.Forms.ComboBox cBOrigen;
        private System.Windows.Forms.ComboBox cBDestino;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
    }
}