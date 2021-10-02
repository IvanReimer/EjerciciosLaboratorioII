namespace FormDiccionario
{
    partial class FormDiccionario
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
            this.rchTxtBox = new System.Windows.Forms.RichTextBox();
            this.calculadorDePalabras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTxtBox
            // 
            this.rchTxtBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.rchTxtBox.Location = new System.Drawing.Point(0, 0);
            this.rchTxtBox.Name = "rchTxtBox";
            this.rchTxtBox.Size = new System.Drawing.Size(800, 388);
            this.rchTxtBox.TabIndex = 0;
            this.rchTxtBox.Text = "";
            // 
            // calculadorDePalabras
            // 
            this.calculadorDePalabras.Location = new System.Drawing.Point(496, 394);
            this.calculadorDePalabras.Name = "calculadorDePalabras";
            this.calculadorDePalabras.Size = new System.Drawing.Size(278, 44);
            this.calculadorDePalabras.TabIndex = 1;
            this.calculadorDePalabras.Text = "Calcular";
            this.calculadorDePalabras.UseVisualStyleBackColor = true;
            this.calculadorDePalabras.Click += new System.EventHandler(this.calculadorDePalabras_Click);
            // 
            // FormDiccionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculadorDePalabras);
            this.Controls.Add(this.rchTxtBox);
            this.Name = "FormDiccionario";
            this.Text = "Contador de palabras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtBox;
        private System.Windows.Forms.Button calculadorDePalabras;
    }
}

