namespace WindowsFormsApp_Trabajo_Evaluacion_3
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
            this.tbx_RUT_Dueño = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown_Mascota_Edad = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Datos_Mascota = new System.Windows.Forms.GroupBox();
            this.comboBox_Tipo_Mascota = new System.Windows.Forms.ComboBox();
            this.groupBox_Datos_Cliente = new System.Windows.Forms.GroupBox();
            this.groupBox_Funciones1 = new System.Windows.Forms.GroupBox();
            this.button_Siguiente = new System.Windows.Forms.Button();
            this.button_Limpiar1 = new System.Windows.Forms.Button();
            this.button_Salir1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mascota_Edad)).BeginInit();
            this.groupBox_Datos_Mascota.SuspendLayout();
            this.groupBox_Datos_Cliente.SuspendLayout();
            this.groupBox_Funciones1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rut Dueño (sin puntos):";
            // 
            // tbx_RUT_Dueño
            // 
            this.tbx_RUT_Dueño.Location = new System.Drawing.Point(125, 21);
            this.tbx_RUT_Dueño.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_RUT_Dueño.MaxLength = 11;
            this.tbx_RUT_Dueño.Name = "tbx_RUT_Dueño";
            this.tbx_RUT_Dueño.Size = new System.Drawing.Size(279, 20);
            this.tbx_RUT_Dueño.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo Mascota:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Edad:";
            // 
            // numericUpDown_Mascota_Edad
            // 
            this.numericUpDown_Mascota_Edad.Location = new System.Drawing.Point(286, 24);
            this.numericUpDown_Mascota_Edad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown_Mascota_Edad.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_Mascota_Edad.Name = "numericUpDown_Mascota_Edad";
            this.numericUpDown_Mascota_Edad.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown_Mascota_Edad.TabIndex = 3;
            // 
            // groupBox_Datos_Mascota
            // 
            this.groupBox_Datos_Mascota.Controls.Add(this.comboBox_Tipo_Mascota);
            this.groupBox_Datos_Mascota.Controls.Add(this.numericUpDown_Mascota_Edad);
            this.groupBox_Datos_Mascota.Controls.Add(this.label2);
            this.groupBox_Datos_Mascota.Controls.Add(this.label3);
            this.groupBox_Datos_Mascota.Location = new System.Drawing.Point(434, 10);
            this.groupBox_Datos_Mascota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Datos_Mascota.Name = "groupBox_Datos_Mascota";
            this.groupBox_Datos_Mascota.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Datos_Mascota.Size = new System.Drawing.Size(394, 58);
            this.groupBox_Datos_Mascota.TabIndex = 2;
            this.groupBox_Datos_Mascota.TabStop = false;
            this.groupBox_Datos_Mascota.Text = "Datos Mascota:";
            // 
            // comboBox_Tipo_Mascota
            // 
            this.comboBox_Tipo_Mascota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Tipo_Mascota.FormattingEnabled = true;
            this.comboBox_Tipo_Mascota.Items.AddRange(new object[] {
            "Gato",
            "Perro",
            "Loro"});
            this.comboBox_Tipo_Mascota.Location = new System.Drawing.Point(83, 23);
            this.comboBox_Tipo_Mascota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Tipo_Mascota.Name = "comboBox_Tipo_Mascota";
            this.comboBox_Tipo_Mascota.Size = new System.Drawing.Size(162, 21);
            this.comboBox_Tipo_Mascota.TabIndex = 2;
            // 
            // groupBox_Datos_Cliente
            // 
            this.groupBox_Datos_Cliente.Controls.Add(this.label1);
            this.groupBox_Datos_Cliente.Controls.Add(this.tbx_RUT_Dueño);
            this.groupBox_Datos_Cliente.Location = new System.Drawing.Point(9, 10);
            this.groupBox_Datos_Cliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Datos_Cliente.Name = "groupBox_Datos_Cliente";
            this.groupBox_Datos_Cliente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Datos_Cliente.Size = new System.Drawing.Size(412, 58);
            this.groupBox_Datos_Cliente.TabIndex = 1;
            this.groupBox_Datos_Cliente.TabStop = false;
            this.groupBox_Datos_Cliente.Text = "Datos Cliente:";
            // 
            // groupBox_Funciones1
            // 
            this.groupBox_Funciones1.Controls.Add(this.button_Siguiente);
            this.groupBox_Funciones1.Controls.Add(this.button_Limpiar1);
            this.groupBox_Funciones1.Controls.Add(this.button_Salir1);
            this.groupBox_Funciones1.Location = new System.Drawing.Point(218, 72);
            this.groupBox_Funciones1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Funciones1.Name = "groupBox_Funciones1";
            this.groupBox_Funciones1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Funciones1.Size = new System.Drawing.Size(387, 122);
            this.groupBox_Funciones1.TabIndex = 37;
            this.groupBox_Funciones1.TabStop = false;
            this.groupBox_Funciones1.Text = "Funciones:";
            // 
            // button_Siguiente
            // 
            this.button_Siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Siguiente.Location = new System.Drawing.Point(47, 58);
            this.button_Siguiente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Siguiente.Name = "button_Siguiente";
            this.button_Siguiente.Size = new System.Drawing.Size(99, 27);
            this.button_Siguiente.TabIndex = 4;
            this.button_Siguiente.Text = "Siguiente";
            this.button_Siguiente.UseVisualStyleBackColor = true;
            this.button_Siguiente.Click += new System.EventHandler(this.button_Siguiente_Click);
            // 
            // button_Limpiar1
            // 
            this.button_Limpiar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Limpiar1.Location = new System.Drawing.Point(146, 58);
            this.button_Limpiar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Limpiar1.Name = "button_Limpiar1";
            this.button_Limpiar1.Size = new System.Drawing.Size(99, 27);
            this.button_Limpiar1.TabIndex = 5;
            this.button_Limpiar1.Text = "Limpiar";
            this.button_Limpiar1.UseVisualStyleBackColor = true;
            this.button_Limpiar1.Click += new System.EventHandler(this.button_Limpiar1_Click);
            // 
            // button_Salir1
            // 
            this.button_Salir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Salir1.Location = new System.Drawing.Point(245, 58);
            this.button_Salir1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Salir1.Name = "button_Salir1";
            this.button_Salir1.Size = new System.Drawing.Size(99, 27);
            this.button_Salir1.TabIndex = 6;
            this.button_Salir1.Text = "Salir";
            this.button_Salir1.UseVisualStyleBackColor = true;
            this.button_Salir1.Click += new System.EventHandler(this.button_Salir1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 204);
            this.Controls.Add(this.groupBox_Funciones1);
            this.Controls.Add(this.groupBox_Datos_Cliente);
            this.Controls.Add(this.groupBox_Datos_Mascota);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Servicio de Veterinaria - Datos";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mascota_Edad)).EndInit();
            this.groupBox_Datos_Mascota.ResumeLayout(false);
            this.groupBox_Datos_Mascota.PerformLayout();
            this.groupBox_Datos_Cliente.ResumeLayout(false);
            this.groupBox_Datos_Cliente.PerformLayout();
            this.groupBox_Funciones1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_RUT_Dueño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown_Mascota_Edad;
        private System.Windows.Forms.GroupBox groupBox_Datos_Mascota;
        private System.Windows.Forms.GroupBox groupBox_Datos_Cliente;
        private System.Windows.Forms.GroupBox groupBox_Funciones1;
        private System.Windows.Forms.Button button_Siguiente;
        private System.Windows.Forms.Button button_Limpiar1;
        private System.Windows.Forms.Button button_Salir1;
        private System.Windows.Forms.ComboBox comboBox_Tipo_Mascota;
    }
}

