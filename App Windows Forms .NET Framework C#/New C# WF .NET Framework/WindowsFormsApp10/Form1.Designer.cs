namespace WindowsFormsApp10
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
            this.tbx_Valor1 = new System.Windows.Forms.TextBox();
            this.tbx_Valor2 = new System.Windows.Forms.TextBox();
            this.tbx_Valor3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_Promedio = new System.Windows.Forms.TextBox();
            this.button_Calcular_Prom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Valor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Valor 3";
            // 
            // tbx_Valor1
            // 
            this.tbx_Valor1.Location = new System.Drawing.Point(132, 35);
            this.tbx_Valor1.Name = "tbx_Valor1";
            this.tbx_Valor1.Size = new System.Drawing.Size(187, 22);
            this.tbx_Valor1.TabIndex = 1;
            // 
            // tbx_Valor2
            // 
            this.tbx_Valor2.Location = new System.Drawing.Point(132, 85);
            this.tbx_Valor2.Name = "tbx_Valor2";
            this.tbx_Valor2.Size = new System.Drawing.Size(187, 22);
            this.tbx_Valor2.TabIndex = 2;
            // 
            // tbx_Valor3
            // 
            this.tbx_Valor3.Location = new System.Drawing.Point(132, 140);
            this.tbx_Valor3.Name = "tbx_Valor3";
            this.tbx_Valor3.Size = new System.Drawing.Size(187, 22);
            this.tbx_Valor3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Promedio";
            // 
            // tbx_Promedio
            // 
            this.tbx_Promedio.Location = new System.Drawing.Point(132, 189);
            this.tbx_Promedio.Name = "tbx_Promedio";
            this.tbx_Promedio.ReadOnly = true;
            this.tbx_Promedio.Size = new System.Drawing.Size(187, 22);
            this.tbx_Promedio.TabIndex = 4;
            // 
            // button_Calcular_Prom
            // 
            this.button_Calcular_Prom.Location = new System.Drawing.Point(114, 242);
            this.button_Calcular_Prom.Name = "button_Calcular_Prom";
            this.button_Calcular_Prom.Size = new System.Drawing.Size(142, 55);
            this.button_Calcular_Prom.TabIndex = 5;
            this.button_Calcular_Prom.Text = "Calcular Promedio";
            this.button_Calcular_Prom.UseVisualStyleBackColor = true;
            this.button_Calcular_Prom.Click += new System.EventHandler(this.button_Calcular_Prom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 327);
            this.Controls.Add(this.button_Calcular_Prom);
            this.Controls.Add(this.tbx_Promedio);
            this.Controls.Add(this.tbx_Valor3);
            this.Controls.Add(this.tbx_Valor2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_Valor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Media";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_Valor1;
        private System.Windows.Forms.TextBox tbx_Valor2;
        private System.Windows.Forms.TextBox tbx_Valor3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_Promedio;
        private System.Windows.Forms.Button button_Calcular_Prom;
    }
}

