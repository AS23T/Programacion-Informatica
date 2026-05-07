
namespace pryPráctico3
{
    partial class frmPráctico3
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
            this.txbNumA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNumB = new System.Windows.Forms.TextBox();
            this.btnCalcularMCD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // txbNumA
            // 
            this.txbNumA.Location = new System.Drawing.Point(22, 55);
            this.txbNumA.Name = "txbNumA";
            this.txbNumA.Size = new System.Drawing.Size(62, 24);
            this.txbNumA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "b";
            // 
            // txbNumB
            // 
            this.txbNumB.Location = new System.Drawing.Point(119, 55);
            this.txbNumB.Name = "txbNumB";
            this.txbNumB.Size = new System.Drawing.Size(62, 24);
            this.txbNumB.TabIndex = 2;
            // 
            // btnCalcularMCD
            // 
            this.btnCalcularMCD.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcularMCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularMCD.ForeColor = System.Drawing.Color.Bisque;
            this.btnCalcularMCD.Location = new System.Drawing.Point(12, 98);
            this.btnCalcularMCD.Name = "btnCalcularMCD";
            this.btnCalcularMCD.Size = new System.Drawing.Size(184, 30);
            this.btnCalcularMCD.TabIndex = 3;
            this.btnCalcularMCD.Text = "Obtener MCD";
            this.btnCalcularMCD.UseVisualStyleBackColor = false;
            this.btnCalcularMCD.Click += new System.EventHandler(this.btnCalcularMCD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ingrese dos números enteros:";
            // 
            // frmPráctico3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 220);
            this.Controls.Add(this.btnCalcularMCD);
            this.Controls.Add(this.txbNumB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNumA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPráctico3";
            this.Text = "MCD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNumA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNumB;
        private System.Windows.Forms.Button btnCalcularMCD;
        private System.Windows.Forms.Label label3;
    }
}

