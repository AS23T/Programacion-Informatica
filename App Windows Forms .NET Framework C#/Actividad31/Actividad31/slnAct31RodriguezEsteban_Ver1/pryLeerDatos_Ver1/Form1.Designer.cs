namespace pryLeerDatos_Ver1
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
            this.numValorN = new System.Windows.Forms.NumericUpDown();
            this.btnProcesarArchivo = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblMayoresN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numValorN)).BeginInit();
            this.SuspendLayout();
            // 
            // numValorN
            // 
            this.numValorN.Location = new System.Drawing.Point(68, 52);
            this.numValorN.Name = "numValorN";
            this.numValorN.Size = new System.Drawing.Size(120, 22);
            this.numValorN.TabIndex = 1;
            // 
            // btnProcesarArchivo
            // 
            this.btnProcesarArchivo.Location = new System.Drawing.Point(83, 238);
            this.btnProcesarArchivo.Name = "btnProcesarArchivo";
            this.btnProcesarArchivo.Size = new System.Drawing.Size(161, 35);
            this.btnProcesarArchivo.TabIndex = 5;
            this.btnProcesarArchivo.Text = "Procesar el Archivo";
            this.btnProcesarArchivo.UseVisualStyleBackColor = true;
            this.btnProcesarArchivo.Click += new System.EventHandler(this.btnProcesarArchivo_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(257, 94);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(15, 16);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "[]";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(257, 174);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(15, 16);
            this.lblPromedio.TabIndex = 4;
            this.lblPromedio.Text = "[]";
            // 
            // lblMayoresN
            // 
            this.lblMayoresN.AutoSize = true;
            this.lblMayoresN.Location = new System.Drawing.Point(257, 136);
            this.lblMayoresN.Name = "lblMayoresN";
            this.lblMayoresN.Size = new System.Drawing.Size(15, 16);
            this.lblMayoresN.TabIndex = 3;
            this.lblMayoresN.Text = "[]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad de registros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Promedio de los valores:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad de números > N:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 313);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMayoresN);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnProcesarArchivo);
            this.Controls.Add(this.numValorN);
            this.Name = "Form1";
            this.Text = "LecturaDeDatos";
            ((System.ComponentModel.ISupportInitialize)(this.numValorN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numValorN;
        private System.Windows.Forms.Button btnProcesarArchivo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblMayoresN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

