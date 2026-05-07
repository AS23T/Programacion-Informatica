namespace WindowsFormsApp4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxHabitacion = new System.Windows.Forms.TextBox();
            this.pictureBoxDonCamaron = new System.Windows.Forms.PictureBox();
            this.groupBoxDesayuno = new System.Windows.Forms.GroupBox();
            this.groupBoxAlmuerzo = new System.Windows.Forms.GroupBox();
            this.groupBoxOnce = new System.Windows.Forms.GroupBox();
            this.checkBoxDesayunoTostadas = new System.Windows.Forms.CheckBox();
            this.checkBoxDesayunoCafeTe = new System.Windows.Forms.CheckBox();
            this.checkBoxDesayunoLeche = new System.Windows.Forms.CheckBox();
            this.checkBoxAlmuerzoEjecutivo = new System.Windows.Forms.CheckBox();
            this.checkBoxAlmuerzoVegetariano = new System.Windows.Forms.CheckBox();
            this.checkBoxAlmuerzoCompleto = new System.Windows.Forms.CheckBox();
            this.checkBoxOnceHuevos = new System.Windows.Forms.CheckBox();
            this.checkBoxOnceCafeTe = new System.Windows.Forms.CheckBox();
            this.checkBoxOnceCena = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonCamaron)).BeginInit();
            this.groupBoxDesayuno.SuspendLayout();
            this.groupBoxAlmuerzo.SuspendLayout();
            this.groupBoxOnce.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Habitacion";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(123, 23);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(100, 20);
            this.tbxNombre.TabIndex = 1;
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(123, 71);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(100, 20);
            this.tbxApellido.TabIndex = 2;
            // 
            // tbxHabitacion
            // 
            this.tbxHabitacion.Location = new System.Drawing.Point(123, 119);
            this.tbxHabitacion.Name = "tbxHabitacion";
            this.tbxHabitacion.Size = new System.Drawing.Size(100, 20);
            this.tbxHabitacion.TabIndex = 3;
            // 
            // pictureBoxDonCamaron
            // 
            this.pictureBoxDonCamaron.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDonCamaron.Image")));
            this.pictureBoxDonCamaron.Location = new System.Drawing.Point(260, 12);
            this.pictureBoxDonCamaron.Name = "pictureBoxDonCamaron";
            this.pictureBoxDonCamaron.Size = new System.Drawing.Size(136, 136);
            this.pictureBoxDonCamaron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDonCamaron.TabIndex = 2;
            this.pictureBoxDonCamaron.TabStop = false;
            // 
            // groupBoxDesayuno
            // 
            this.groupBoxDesayuno.Controls.Add(this.checkBoxDesayunoLeche);
            this.groupBoxDesayuno.Controls.Add(this.checkBoxDesayunoCafeTe);
            this.groupBoxDesayuno.Controls.Add(this.checkBoxDesayunoTostadas);
            this.groupBoxDesayuno.Location = new System.Drawing.Point(27, 171);
            this.groupBoxDesayuno.Name = "groupBoxDesayuno";
            this.groupBoxDesayuno.Size = new System.Drawing.Size(109, 90);
            this.groupBoxDesayuno.TabIndex = 4;
            this.groupBoxDesayuno.TabStop = false;
            this.groupBoxDesayuno.Text = "Desayuno";
            // 
            // groupBoxAlmuerzo
            // 
            this.groupBoxAlmuerzo.Controls.Add(this.checkBoxAlmuerzoCompleto);
            this.groupBoxAlmuerzo.Controls.Add(this.checkBoxAlmuerzoVegetariano);
            this.groupBoxAlmuerzo.Controls.Add(this.checkBoxAlmuerzoEjecutivo);
            this.groupBoxAlmuerzo.Location = new System.Drawing.Point(155, 171);
            this.groupBoxAlmuerzo.Name = "groupBoxAlmuerzo";
            this.groupBoxAlmuerzo.Size = new System.Drawing.Size(109, 90);
            this.groupBoxAlmuerzo.TabIndex = 5;
            this.groupBoxAlmuerzo.TabStop = false;
            this.groupBoxAlmuerzo.Text = "Almuerzo";
            // 
            // groupBoxOnce
            // 
            this.groupBoxOnce.Controls.Add(this.checkBoxOnceCena);
            this.groupBoxOnce.Controls.Add(this.checkBoxOnceCafeTe);
            this.groupBoxOnce.Controls.Add(this.checkBoxOnceHuevos);
            this.groupBoxOnce.Location = new System.Drawing.Point(283, 171);
            this.groupBoxOnce.Name = "groupBoxOnce";
            this.groupBoxOnce.Size = new System.Drawing.Size(109, 90);
            this.groupBoxOnce.TabIndex = 6;
            this.groupBoxOnce.TabStop = false;
            this.groupBoxOnce.Text = "Once";
            // 
            // checkBoxDesayunoTostadas
            // 
            this.checkBoxDesayunoTostadas.AutoSize = true;
            this.checkBoxDesayunoTostadas.Location = new System.Drawing.Point(21, 19);
            this.checkBoxDesayunoTostadas.Name = "checkBoxDesayunoTostadas";
            this.checkBoxDesayunoTostadas.Size = new System.Drawing.Size(70, 17);
            this.checkBoxDesayunoTostadas.TabIndex = 4;
            this.checkBoxDesayunoTostadas.Text = "Tostadas";
            this.checkBoxDesayunoTostadas.UseVisualStyleBackColor = true;
            // 
            // checkBoxDesayunoCafeTe
            // 
            this.checkBoxDesayunoCafeTe.AutoSize = true;
            this.checkBoxDesayunoCafeTe.Location = new System.Drawing.Point(21, 42);
            this.checkBoxDesayunoCafeTe.Name = "checkBoxDesayunoCafeTe";
            this.checkBoxDesayunoCafeTe.Size = new System.Drawing.Size(66, 17);
            this.checkBoxDesayunoCafeTe.TabIndex = 4;
            this.checkBoxDesayunoCafeTe.Text = "Cafe/Te";
            this.checkBoxDesayunoCafeTe.UseVisualStyleBackColor = true;
            // 
            // checkBoxDesayunoLeche
            // 
            this.checkBoxDesayunoLeche.AutoSize = true;
            this.checkBoxDesayunoLeche.Location = new System.Drawing.Point(21, 65);
            this.checkBoxDesayunoLeche.Name = "checkBoxDesayunoLeche";
            this.checkBoxDesayunoLeche.Size = new System.Drawing.Size(56, 17);
            this.checkBoxDesayunoLeche.TabIndex = 4;
            this.checkBoxDesayunoLeche.Text = "Leche";
            this.checkBoxDesayunoLeche.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlmuerzoEjecutivo
            // 
            this.checkBoxAlmuerzoEjecutivo.AutoSize = true;
            this.checkBoxAlmuerzoEjecutivo.Location = new System.Drawing.Point(12, 19);
            this.checkBoxAlmuerzoEjecutivo.Name = "checkBoxAlmuerzoEjecutivo";
            this.checkBoxAlmuerzoEjecutivo.Size = new System.Drawing.Size(70, 17);
            this.checkBoxAlmuerzoEjecutivo.TabIndex = 5;
            this.checkBoxAlmuerzoEjecutivo.Text = "Ejecutivo";
            this.checkBoxAlmuerzoEjecutivo.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlmuerzoVegetariano
            // 
            this.checkBoxAlmuerzoVegetariano.AutoSize = true;
            this.checkBoxAlmuerzoVegetariano.Location = new System.Drawing.Point(12, 42);
            this.checkBoxAlmuerzoVegetariano.Name = "checkBoxAlmuerzoVegetariano";
            this.checkBoxAlmuerzoVegetariano.Size = new System.Drawing.Size(83, 17);
            this.checkBoxAlmuerzoVegetariano.TabIndex = 5;
            this.checkBoxAlmuerzoVegetariano.Text = "Vegetariano";
            this.checkBoxAlmuerzoVegetariano.UseVisualStyleBackColor = true;
            // 
            // checkBoxAlmuerzoCompleto
            // 
            this.checkBoxAlmuerzoCompleto.AutoSize = true;
            this.checkBoxAlmuerzoCompleto.Location = new System.Drawing.Point(12, 65);
            this.checkBoxAlmuerzoCompleto.Name = "checkBoxAlmuerzoCompleto";
            this.checkBoxAlmuerzoCompleto.Size = new System.Drawing.Size(70, 17);
            this.checkBoxAlmuerzoCompleto.TabIndex = 5;
            this.checkBoxAlmuerzoCompleto.Text = "Completo";
            this.checkBoxAlmuerzoCompleto.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnceHuevos
            // 
            this.checkBoxOnceHuevos.AutoSize = true;
            this.checkBoxOnceHuevos.Location = new System.Drawing.Point(22, 19);
            this.checkBoxOnceHuevos.Name = "checkBoxOnceHuevos";
            this.checkBoxOnceHuevos.Size = new System.Drawing.Size(63, 17);
            this.checkBoxOnceHuevos.TabIndex = 6;
            this.checkBoxOnceHuevos.Text = "Huevos";
            this.checkBoxOnceHuevos.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnceCafeTe
            // 
            this.checkBoxOnceCafeTe.AutoSize = true;
            this.checkBoxOnceCafeTe.Location = new System.Drawing.Point(22, 42);
            this.checkBoxOnceCafeTe.Name = "checkBoxOnceCafeTe";
            this.checkBoxOnceCafeTe.Size = new System.Drawing.Size(66, 17);
            this.checkBoxOnceCafeTe.TabIndex = 6;
            this.checkBoxOnceCafeTe.Text = "Cafe/Te";
            this.checkBoxOnceCafeTe.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnceCena
            // 
            this.checkBoxOnceCena.AutoSize = true;
            this.checkBoxOnceCena.Location = new System.Drawing.Point(22, 65);
            this.checkBoxOnceCena.Name = "checkBoxOnceCena";
            this.checkBoxOnceCena.Size = new System.Drawing.Size(51, 17);
            this.checkBoxOnceCena.TabIndex = 6;
            this.checkBoxOnceCena.Text = "Cena";
            this.checkBoxOnceCena.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 288);
            this.Controls.Add(this.groupBoxOnce);
            this.Controls.Add(this.groupBoxAlmuerzo);
            this.Controls.Add(this.groupBoxDesayuno);
            this.Controls.Add(this.pictureBoxDonCamaron);
            this.Controls.Add(this.tbxHabitacion);
            this.Controls.Add(this.tbxApellido);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonCamaron)).EndInit();
            this.groupBoxDesayuno.ResumeLayout(false);
            this.groupBoxDesayuno.PerformLayout();
            this.groupBoxAlmuerzo.ResumeLayout(false);
            this.groupBoxAlmuerzo.PerformLayout();
            this.groupBoxOnce.ResumeLayout(false);
            this.groupBoxOnce.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxHabitacion;
        private System.Windows.Forms.PictureBox pictureBoxDonCamaron;
        private System.Windows.Forms.GroupBox groupBoxDesayuno;
        private System.Windows.Forms.GroupBox groupBoxAlmuerzo;
        private System.Windows.Forms.GroupBox groupBoxOnce;
        private System.Windows.Forms.CheckBox checkBoxDesayunoLeche;
        private System.Windows.Forms.CheckBox checkBoxDesayunoCafeTe;
        private System.Windows.Forms.CheckBox checkBoxDesayunoTostadas;
        private System.Windows.Forms.CheckBox checkBoxAlmuerzoCompleto;
        private System.Windows.Forms.CheckBox checkBoxAlmuerzoVegetariano;
        private System.Windows.Forms.CheckBox checkBoxAlmuerzoEjecutivo;
        private System.Windows.Forms.CheckBox checkBoxOnceCena;
        private System.Windows.Forms.CheckBox checkBoxOnceCafeTe;
        private System.Windows.Forms.CheckBox checkBoxOnceHuevos;
    }
}

