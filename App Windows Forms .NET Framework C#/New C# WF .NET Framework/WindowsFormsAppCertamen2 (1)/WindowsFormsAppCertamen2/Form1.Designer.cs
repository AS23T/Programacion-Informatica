namespace WindowsFormsAppCertamen2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNota1 = new System.Windows.Forms.TextBox();
            this.tbxNota2 = new System.Windows.Forms.TextBox();
            this.tbxNota3 = new System.Windows.Forms.TextBox();
            this.buttonCalcularProm = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonOtroCalculo = new System.Windows.Forms.Button();
            this.labelSituacion = new System.Windows.Forms.Label();
            this.tbxPromedio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 1 20%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nota 2 35%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nota 3 45%";
            // 
            // tbxNota1
            // 
            this.tbxNota1.Location = new System.Drawing.Point(181, 21);
            this.tbxNota1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNota1.Name = "tbxNota1";
            this.tbxNota1.Size = new System.Drawing.Size(132, 22);
            this.tbxNota1.TabIndex = 1;
            // 
            // tbxNota2
            // 
            this.tbxNota2.Location = new System.Drawing.Point(181, 110);
            this.tbxNota2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNota2.Name = "tbxNota2";
            this.tbxNota2.Size = new System.Drawing.Size(132, 22);
            this.tbxNota2.TabIndex = 2;
            // 
            // tbxNota3
            // 
            this.tbxNota3.Location = new System.Drawing.Point(181, 192);
            this.tbxNota3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNota3.Name = "tbxNota3";
            this.tbxNota3.Size = new System.Drawing.Size(132, 22);
            this.tbxNota3.TabIndex = 3;
            // 
            // buttonCalcularProm
            // 
            this.buttonCalcularProm.Location = new System.Drawing.Point(59, 299);
            this.buttonCalcularProm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCalcularProm.Name = "buttonCalcularProm";
            this.buttonCalcularProm.Size = new System.Drawing.Size(131, 28);
            this.buttonCalcularProm.TabIndex = 4;
            this.buttonCalcularProm.Text = "Calcular Prom";
            this.buttonCalcularProm.UseVisualStyleBackColor = true;
            this.buttonCalcularProm.Click += new System.EventHandler(this.buttonCalcularProm_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(168, 345);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(100, 28);
            this.buttonSalir.TabIndex = 6;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonOtroCalculo
            // 
            this.buttonOtroCalculo.Location = new System.Drawing.Point(273, 299);
            this.buttonOtroCalculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonOtroCalculo.Name = "buttonOtroCalculo";
            this.buttonOtroCalculo.Size = new System.Drawing.Size(100, 28);
            this.buttonOtroCalculo.TabIndex = 5;
            this.buttonOtroCalculo.Text = "Otro Calc?";
            this.buttonOtroCalculo.UseVisualStyleBackColor = true;
            this.buttonOtroCalculo.Click += new System.EventHandler(this.buttonOtroCalculo_Click);
            // 
            // labelSituacion
            // 
            this.labelSituacion.AutoSize = true;
            this.labelSituacion.Location = new System.Drawing.Point(55, 394);
            this.labelSituacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSituacion.Name = "labelSituacion";
            this.labelSituacion.Size = new System.Drawing.Size(79, 16);
            this.labelSituacion.TabIndex = 3;
            this.labelSituacion.Text = "SITUACION";
            // 
            // tbxPromedio
            // 
            this.tbxPromedio.Enabled = false;
            this.tbxPromedio.Location = new System.Drawing.Point(305, 255);
            this.tbxPromedio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPromedio.Name = "tbxPromedio";
            this.tbxPromedio.Size = new System.Drawing.Size(132, 22);
            this.tbxPromedio.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Promedio Ponderado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 433);
            this.Controls.Add(this.tbxPromedio);
            this.Controls.Add(this.labelSituacion);
            this.Controls.Add(this.buttonOtroCalculo);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonCalcularProm);
            this.Controls.Add(this.tbxNota3);
            this.Controls.Add(this.tbxNota2);
            this.Controls.Add(this.tbxNota1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Calcular Promedio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNota1;
        private System.Windows.Forms.TextBox tbxNota2;
        private System.Windows.Forms.TextBox tbxNota3;
        private System.Windows.Forms.Button buttonCalcularProm;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonOtroCalculo;
        private System.Windows.Forms.Label labelSituacion;
        private System.Windows.Forms.TextBox tbxPromedio;
        private System.Windows.Forms.Label label5;
    }
}

