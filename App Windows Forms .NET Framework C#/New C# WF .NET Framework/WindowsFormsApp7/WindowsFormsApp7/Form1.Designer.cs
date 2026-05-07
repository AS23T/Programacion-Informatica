namespace WindowsFormsApp7
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
            this.tbxPulgadas = new System.Windows.Forms.TextBox();
            this.tbxCM = new System.Windows.Forms.TextBox();
            this.button_ConvertirLasPulgadas = new System.Windows.Forms.Button();
            this.button_ConvertirLosCM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pulgadas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Centimetros";
            // 
            // tbxPulgadas
            // 
            this.tbxPulgadas.Location = new System.Drawing.Point(46, 58);
            this.tbxPulgadas.Name = "tbxPulgadas";
            this.tbxPulgadas.Size = new System.Drawing.Size(100, 20);
            this.tbxPulgadas.TabIndex = 1;
            // 
            // tbxCM
            // 
            this.tbxCM.Location = new System.Drawing.Point(176, 58);
            this.tbxCM.Name = "tbxCM";
            this.tbxCM.Size = new System.Drawing.Size(100, 20);
            this.tbxCM.TabIndex = 2;
            // 
            // button_ConvertirLasPulgadas
            // 
            this.button_ConvertirLasPulgadas.Location = new System.Drawing.Point(46, 93);
            this.button_ConvertirLasPulgadas.Name = "button_ConvertirLasPulgadas";
            this.button_ConvertirLasPulgadas.Size = new System.Drawing.Size(100, 23);
            this.button_ConvertirLasPulgadas.TabIndex = 2;
            this.button_ConvertirLasPulgadas.Text = "Convertir Pulg";
            this.button_ConvertirLasPulgadas.UseVisualStyleBackColor = true;
            this.button_ConvertirLasPulgadas.Click += new System.EventHandler(this.button_ConvertirLasPulgadas_Click);
            // 
            // button_ConvertirLosCM
            // 
            this.button_ConvertirLosCM.Location = new System.Drawing.Point(176, 93);
            this.button_ConvertirLosCM.Name = "button_ConvertirLosCM";
            this.button_ConvertirLosCM.Size = new System.Drawing.Size(100, 23);
            this.button_ConvertirLosCM.TabIndex = 2;
            this.button_ConvertirLosCM.Text = "Convertir CM";
            this.button_ConvertirLosCM.UseVisualStyleBackColor = true;
            this.button_ConvertirLosCM.Click += new System.EventHandler(this.button_ConvertirLosCM_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 168);
            this.Controls.Add(this.button_ConvertirLosCM);
            this.Controls.Add(this.button_ConvertirLasPulgadas);
            this.Controls.Add(this.tbxCM);
            this.Controls.Add(this.tbxPulgadas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Convertidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPulgadas;
        private System.Windows.Forms.TextBox tbxCM;
        private System.Windows.Forms.Button button_ConvertirLasPulgadas;
        private System.Windows.Forms.Button button_ConvertirLosCM;
    }
}

