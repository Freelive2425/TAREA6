namespace WindowsFormsApplication1
{
    partial class FrmListarTotalPasajeros
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
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cBOrigen = new System.Windows.Forms.ComboBox();
            this.cBDestino = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ciudades de Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ciudades de Destino";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total de Personas:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(228, 129);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 19);
            this.lbTotal.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(54, 201);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 37);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cBOrigen
            // 
            this.cBOrigen.FormattingEnabled = true;
            this.cBOrigen.Items.AddRange(new object[] {
            "Lima",
            "Bogotá",
            "Panamá",
            "Brasil"});
            this.cBOrigen.Location = new System.Drawing.Point(152, 23);
            this.cBOrigen.Name = "cBOrigen";
            this.cBOrigen.Size = new System.Drawing.Size(145, 21);
            this.cBOrigen.TabIndex = 5;
            // 
            // cBDestino
            // 
            this.cBDestino.FormattingEnabled = true;
            this.cBDestino.Items.AddRange(new object[] {
            "Lima",
            "Bogotá",
            "Panamá",
            "Brasil"});
            this.cBDestino.Location = new System.Drawing.Point(152, 62);
            this.cBDestino.Name = "cBDestino";
            this.cBDestino.Size = new System.Drawing.Size(145, 21);
            this.cBDestino.TabIndex = 6;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(212, 201);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 37);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmListarTotalPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 262);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cBDestino);
            this.Controls.Add(this.cBOrigen);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmListarTotalPasajeros";
            this.Text = "FrmListarTotalPasajeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cBOrigen;
        private System.Windows.Forms.ComboBox cBDestino;
        private System.Windows.Forms.Button btnSalir;
    }
}