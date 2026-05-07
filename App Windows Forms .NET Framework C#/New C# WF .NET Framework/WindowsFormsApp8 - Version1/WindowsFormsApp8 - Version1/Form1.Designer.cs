namespace WindowsFormsApp8
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPrecioUnitario1 = new System.Windows.Forms.TextBox();
            this.tbxPrecioUnitario2 = new System.Windows.Forms.TextBox();
            this.tbxPrecioUnitario4 = new System.Windows.Forms.TextBox();
            this.tbxPrecioUnitario3 = new System.Windows.Forms.TextBox();
            this.numericUpDownCantidad1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCantidad2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCantidad3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCantidad4 = new System.Windows.Forms.NumericUpDown();
            this.tbxTotalItem1 = new System.Windows.Forms.TextBox();
            this.tbxTotalItem2 = new System.Windows.Forms.TextBox();
            this.tbxTotalItem4 = new System.Windows.Forms.TextBox();
            this.tbxTotalItem3 = new System.Windows.Forms.TextBox();
            this.tbxSubTotal = new System.Windows.Forms.TextBox();
            this.tbxTOTAL = new System.Windows.Forms.TextBox();
            this.tbxIVA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.comboBoxItem1 = new System.Windows.Forms.ComboBox();
            this.comboBoxItem2 = new System.Windows.Forms.ComboBox();
            this.comboBoxItem3 = new System.Windows.Forms.ComboBox();
            this.comboBoxItem4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "SubTotal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Item";
            // 
            // tbxPrecioUnitario1
            // 
            this.tbxPrecioUnitario1.Location = new System.Drawing.Point(370, 69);
            this.tbxPrecioUnitario1.Name = "tbxPrecioUnitario1";
            this.tbxPrecioUnitario1.ReadOnly = true;
            this.tbxPrecioUnitario1.Size = new System.Drawing.Size(100, 22);
            this.tbxPrecioUnitario1.TabIndex = 10;
            this.tbxPrecioUnitario1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxPrecioUnitario2
            // 
            this.tbxPrecioUnitario2.Location = new System.Drawing.Point(370, 114);
            this.tbxPrecioUnitario2.Name = "tbxPrecioUnitario2";
            this.tbxPrecioUnitario2.ReadOnly = true;
            this.tbxPrecioUnitario2.Size = new System.Drawing.Size(100, 22);
            this.tbxPrecioUnitario2.TabIndex = 11;
            this.tbxPrecioUnitario2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxPrecioUnitario4
            // 
            this.tbxPrecioUnitario4.Location = new System.Drawing.Point(370, 209);
            this.tbxPrecioUnitario4.Name = "tbxPrecioUnitario4";
            this.tbxPrecioUnitario4.ReadOnly = true;
            this.tbxPrecioUnitario4.Size = new System.Drawing.Size(100, 22);
            this.tbxPrecioUnitario4.TabIndex = 13;
            this.tbxPrecioUnitario4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxPrecioUnitario3
            // 
            this.tbxPrecioUnitario3.Location = new System.Drawing.Point(370, 164);
            this.tbxPrecioUnitario3.Name = "tbxPrecioUnitario3";
            this.tbxPrecioUnitario3.ReadOnly = true;
            this.tbxPrecioUnitario3.Size = new System.Drawing.Size(100, 22);
            this.tbxPrecioUnitario3.TabIndex = 12;
            this.tbxPrecioUnitario3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownCantidad1
            // 
            this.numericUpDownCantidad1.Location = new System.Drawing.Point(207, 69);
            this.numericUpDownCantidad1.Name = "numericUpDownCantidad1";
            this.numericUpDownCantidad1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCantidad1.TabIndex = 5;
            // 
            // numericUpDownCantidad2
            // 
            this.numericUpDownCantidad2.Location = new System.Drawing.Point(207, 115);
            this.numericUpDownCantidad2.Name = "numericUpDownCantidad2";
            this.numericUpDownCantidad2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCantidad2.TabIndex = 6;
            // 
            // numericUpDownCantidad3
            // 
            this.numericUpDownCantidad3.Location = new System.Drawing.Point(207, 164);
            this.numericUpDownCantidad3.Name = "numericUpDownCantidad3";
            this.numericUpDownCantidad3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCantidad3.TabIndex = 7;
            // 
            // numericUpDownCantidad4
            // 
            this.numericUpDownCantidad4.Location = new System.Drawing.Point(207, 210);
            this.numericUpDownCantidad4.Name = "numericUpDownCantidad4";
            this.numericUpDownCantidad4.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownCantidad4.TabIndex = 8;
            // 
            // tbxTotalItem1
            // 
            this.tbxTotalItem1.Enabled = false;
            this.tbxTotalItem1.Location = new System.Drawing.Point(542, 70);
            this.tbxTotalItem1.Name = "tbxTotalItem1";
            this.tbxTotalItem1.ReadOnly = true;
            this.tbxTotalItem1.Size = new System.Drawing.Size(100, 22);
            this.tbxTotalItem1.TabIndex = 14;
            this.tbxTotalItem1.TabStop = false;
            this.tbxTotalItem1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTotalItem2
            // 
            this.tbxTotalItem2.Enabled = false;
            this.tbxTotalItem2.Location = new System.Drawing.Point(542, 115);
            this.tbxTotalItem2.Name = "tbxTotalItem2";
            this.tbxTotalItem2.ReadOnly = true;
            this.tbxTotalItem2.Size = new System.Drawing.Size(100, 22);
            this.tbxTotalItem2.TabIndex = 15;
            this.tbxTotalItem2.TabStop = false;
            this.tbxTotalItem2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTotalItem4
            // 
            this.tbxTotalItem4.Enabled = false;
            this.tbxTotalItem4.Location = new System.Drawing.Point(542, 210);
            this.tbxTotalItem4.Name = "tbxTotalItem4";
            this.tbxTotalItem4.ReadOnly = true;
            this.tbxTotalItem4.Size = new System.Drawing.Size(100, 22);
            this.tbxTotalItem4.TabIndex = 17;
            this.tbxTotalItem4.TabStop = false;
            this.tbxTotalItem4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTotalItem3
            // 
            this.tbxTotalItem3.Enabled = false;
            this.tbxTotalItem3.Location = new System.Drawing.Point(542, 165);
            this.tbxTotalItem3.Name = "tbxTotalItem3";
            this.tbxTotalItem3.ReadOnly = true;
            this.tbxTotalItem3.Size = new System.Drawing.Size(100, 22);
            this.tbxTotalItem3.TabIndex = 16;
            this.tbxTotalItem3.TabStop = false;
            this.tbxTotalItem3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxSubTotal
            // 
            this.tbxSubTotal.Enabled = false;
            this.tbxSubTotal.Location = new System.Drawing.Point(542, 280);
            this.tbxSubTotal.Name = "tbxSubTotal";
            this.tbxSubTotal.ReadOnly = true;
            this.tbxSubTotal.Size = new System.Drawing.Size(100, 22);
            this.tbxSubTotal.TabIndex = 18;
            this.tbxSubTotal.TabStop = false;
            this.tbxSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxTOTAL
            // 
            this.tbxTOTAL.Enabled = false;
            this.tbxTOTAL.Location = new System.Drawing.Point(542, 375);
            this.tbxTOTAL.Name = "tbxTOTAL";
            this.tbxTOTAL.ReadOnly = true;
            this.tbxTOTAL.Size = new System.Drawing.Size(100, 22);
            this.tbxTOTAL.TabIndex = 20;
            this.tbxTOTAL.TabStop = false;
            this.tbxTOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxIVA
            // 
            this.tbxIVA.Enabled = false;
            this.tbxIVA.Location = new System.Drawing.Point(542, 330);
            this.tbxIVA.Name = "tbxIVA";
            this.tbxIVA.ReadOnly = true;
            this.tbxIVA.Size = new System.Drawing.Size(100, 22);
            this.tbxIVA.TabIndex = 19;
            this.tbxIVA.TabStop = false;
            this.tbxIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "IVA (19%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(453, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "TOTAL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Precio Unitario";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.Location = new System.Drawing.Point(131, 311);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(173, 60);
            this.buttonCalcular.TabIndex = 9;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // comboBoxItem1
            // 
            this.comboBoxItem1.FormattingEnabled = true;
            this.comboBoxItem1.Items.AddRange(new object[] {
            "Guantes",
            "Gorro",
            "Camisa",
            "Poleron"});
            this.comboBoxItem1.Location = new System.Drawing.Point(41, 67);
            this.comboBoxItem1.Name = "comboBoxItem1";
            this.comboBoxItem1.Size = new System.Drawing.Size(121, 24);
            this.comboBoxItem1.TabIndex = 1;
            // 
            // comboBoxItem2
            // 
            this.comboBoxItem2.FormattingEnabled = true;
            this.comboBoxItem2.Items.AddRange(new object[] {
            "Guantes",
            "Gorro",
            "Camisa",
            "Poleron"});
            this.comboBoxItem2.Location = new System.Drawing.Point(41, 115);
            this.comboBoxItem2.Name = "comboBoxItem2";
            this.comboBoxItem2.Size = new System.Drawing.Size(121, 24);
            this.comboBoxItem2.TabIndex = 2;
            // 
            // comboBoxItem3
            // 
            this.comboBoxItem3.FormattingEnabled = true;
            this.comboBoxItem3.Items.AddRange(new object[] {
            "Guantes",
            "Gorro",
            "Camisa",
            "Poleron"});
            this.comboBoxItem3.Location = new System.Drawing.Point(41, 159);
            this.comboBoxItem3.Name = "comboBoxItem3";
            this.comboBoxItem3.Size = new System.Drawing.Size(121, 24);
            this.comboBoxItem3.TabIndex = 3;
            // 
            // comboBoxItem4
            // 
            this.comboBoxItem4.FormattingEnabled = true;
            this.comboBoxItem4.Items.AddRange(new object[] {
            "Guantes",
            "Gorro",
            "Camisa",
            "Poleron"});
            this.comboBoxItem4.Location = new System.Drawing.Point(41, 207);
            this.comboBoxItem4.Name = "comboBoxItem4";
            this.comboBoxItem4.Size = new System.Drawing.Size(121, 24);
            this.comboBoxItem4.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxItem4);
            this.Controls.Add(this.comboBoxItem3);
            this.Controls.Add(this.comboBoxItem2);
            this.Controls.Add(this.comboBoxItem1);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.numericUpDownCantidad4);
            this.Controls.Add(this.numericUpDownCantidad3);
            this.Controls.Add(this.numericUpDownCantidad2);
            this.Controls.Add(this.numericUpDownCantidad1);
            this.Controls.Add(this.tbxIVA);
            this.Controls.Add(this.tbxTotalItem3);
            this.Controls.Add(this.tbxPrecioUnitario3);
            this.Controls.Add(this.tbxTOTAL);
            this.Controls.Add(this.tbxSubTotal);
            this.Controls.Add(this.tbxTotalItem4);
            this.Controls.Add(this.tbxTotalItem2);
            this.Controls.Add(this.tbxPrecioUnitario4);
            this.Controls.Add(this.tbxPrecioUnitario2);
            this.Controls.Add(this.tbxTotalItem1);
            this.Controls.Add(this.tbxPrecioUnitario1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Orden de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPrecioUnitario1;
        private System.Windows.Forms.TextBox tbxPrecioUnitario2;
        private System.Windows.Forms.TextBox tbxPrecioUnitario4;
        private System.Windows.Forms.TextBox tbxPrecioUnitario3;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad1;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad2;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad3;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad4;
        private System.Windows.Forms.TextBox tbxTotalItem1;
        private System.Windows.Forms.TextBox tbxTotalItem2;
        private System.Windows.Forms.TextBox tbxTotalItem4;
        private System.Windows.Forms.TextBox tbxTotalItem3;
        private System.Windows.Forms.TextBox tbxSubTotal;
        private System.Windows.Forms.TextBox tbxTOTAL;
        private System.Windows.Forms.TextBox tbxIVA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.ComboBox comboBoxItem1;
        private System.Windows.Forms.ComboBox comboBoxItem2;
        private System.Windows.Forms.ComboBox comboBoxItem3;
        private System.Windows.Forms.ComboBox comboBoxItem4;
    }
}

