namespace WindowsFormsApp11
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
            this.label_Contador = new System.Windows.Forms.Label();
            this.button_Agregar = new System.Windows.Forms.Button();
            this.button_Quitar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Contador
            // 
            this.label_Contador.AutoSize = true;
            this.label_Contador.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Contador.Location = new System.Drawing.Point(146, 32);
            this.label_Contador.Name = "label_Contador";
            this.label_Contador.Size = new System.Drawing.Size(49, 54);
            this.label_Contador.TabIndex = 0;
            this.label_Contador.Text = "0";
            // 
            // button_Agregar
            // 
            this.button_Agregar.Location = new System.Drawing.Point(29, 114);
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.Size = new System.Drawing.Size(123, 46);
            this.button_Agregar.TabIndex = 1;
            this.button_Agregar.Text = "Agregar";
            this.button_Agregar.UseVisualStyleBackColor = true;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // button_Quitar
            // 
            this.button_Quitar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Quitar.Location = new System.Drawing.Point(190, 114);
            this.button_Quitar.Name = "button_Quitar";
            this.button_Quitar.Size = new System.Drawing.Size(123, 46);
            this.button_Quitar.TabIndex = 2;
            this.button_Quitar.Text = "Quitar";
            this.button_Quitar.UseVisualStyleBackColor = true;
            this.button_Quitar.Click += new System.EventHandler(this.button_Quitar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_Agregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Quitar;
            this.ClientSize = new System.Drawing.Size(341, 184);
            this.Controls.Add(this.button_Quitar);
            this.Controls.Add(this.button_Agregar);
            this.Controls.Add(this.label_Contador);
            this.Name = "Form1";
            this.Text = "Contador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Contador;
        private System.Windows.Forms.Button button_Agregar;
        private System.Windows.Forms.Button button_Quitar;
    }
}

