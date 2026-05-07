namespace WindowsFormsApp12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button_Asignar = new System.Windows.Forms.Button();
            this.button_Salir = new System.Windows.Forms.Button();
            this.pictureBox_Icono = new System.Windows.Forms.PictureBox();
            this.comboBox_TipoAsiento = new System.Windows.Forms.ComboBox();
            this.lboxDestino = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icono)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Destino";
            // 
            // button_Asignar
            // 
            this.button_Asignar.Location = new System.Drawing.Point(87, 269);
            this.button_Asignar.Name = "button_Asignar";
            this.button_Asignar.Size = new System.Drawing.Size(75, 23);
            this.button_Asignar.TabIndex = 1;
            this.button_Asignar.Text = "Asignar";
            this.button_Asignar.UseVisualStyleBackColor = true;
            this.button_Asignar.Click += new System.EventHandler(this.button_Asignar_Click);
            // 
            // button_Salir
            // 
            this.button_Salir.Location = new System.Drawing.Point(272, 269);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(75, 23);
            this.button_Salir.TabIndex = 1;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = true;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // pictureBox_Icono
            // 
            this.pictureBox_Icono.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Icono.Image")));
            this.pictureBox_Icono.Location = new System.Drawing.Point(272, 12);
            this.pictureBox_Icono.Name = "pictureBox_Icono";
            this.pictureBox_Icono.Size = new System.Drawing.Size(199, 85);
            this.pictureBox_Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Icono.TabIndex = 2;
            this.pictureBox_Icono.TabStop = false;
            // 
            // comboBox_TipoAsiento
            // 
            this.comboBox_TipoAsiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TipoAsiento.FormattingEnabled = true;
            this.comboBox_TipoAsiento.Items.AddRange(new object[] {
            "Pasillo",
            "Medio",
            "Ventana"});
            this.comboBox_TipoAsiento.Location = new System.Drawing.Point(272, 166);
            this.comboBox_TipoAsiento.Name = "comboBox_TipoAsiento";
            this.comboBox_TipoAsiento.Size = new System.Drawing.Size(121, 24);
            this.comboBox_TipoAsiento.TabIndex = 3;
            // 
            // lboxDestino
            // 
            this.lboxDestino.FormattingEnabled = true;
            this.lboxDestino.ItemHeight = 16;
            this.lboxDestino.Location = new System.Drawing.Point(42, 115);
            this.lboxDestino.Name = "lboxDestino";
            this.lboxDestino.Size = new System.Drawing.Size(120, 84);
            this.lboxDestino.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo Asiento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 351);
            this.Controls.Add(this.lboxDestino);
            this.Controls.Add(this.comboBox_TipoAsiento);
            this.Controls.Add(this.pictureBox_Icono);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.button_Asignar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Opciones Vuelos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Asignar;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.PictureBox pictureBox_Icono;
        private System.Windows.Forms.ComboBox comboBox_TipoAsiento;
        private System.Windows.Forms.ListBox lboxDestino;
        private System.Windows.Forms.Label label2;
    }
}

