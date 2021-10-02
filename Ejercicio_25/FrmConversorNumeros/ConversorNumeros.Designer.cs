namespace FrmConversorNumeros
{
    partial class ConversorNumeros
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
            this.btnBinarioDecimal = new System.Windows.Forms.Button();
            this.btnDecimalABinario = new System.Windows.Forms.Button();
            this.lblBinario = new System.Windows.Forms.Label();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtDecimalABinario = new System.Windows.Forms.TextBox();
            this.txtBinarioADecimal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBinarioDecimal
            // 
            this.btnBinarioDecimal.Location = new System.Drawing.Point(418, 31);
            this.btnBinarioDecimal.Name = "btnBinarioDecimal";
            this.btnBinarioDecimal.Size = new System.Drawing.Size(123, 36);
            this.btnBinarioDecimal.TabIndex = 0;
            this.btnBinarioDecimal.Text = "->";
            this.btnBinarioDecimal.UseVisualStyleBackColor = true;
            this.btnBinarioDecimal.Click += new System.EventHandler(this.btnBinarioDecimal_Click);
            // 
            // btnDecimalABinario
            // 
            this.btnDecimalABinario.Location = new System.Drawing.Point(418, 108);
            this.btnDecimalABinario.Name = "btnDecimalABinario";
            this.btnDecimalABinario.Size = new System.Drawing.Size(123, 35);
            this.btnDecimalABinario.TabIndex = 1;
            this.btnDecimalABinario.Text = "->";
            this.btnDecimalABinario.UseVisualStyleBackColor = true;
            this.btnDecimalABinario.Click += new System.EventHandler(this.btnDecimalABinario_Click);
            // 
            // lblBinario
            // 
            this.lblBinario.AutoSize = true;
            this.lblBinario.Location = new System.Drawing.Point(43, 37);
            this.lblBinario.Name = "lblBinario";
            this.lblBinario.Size = new System.Drawing.Size(198, 30);
            this.lblBinario.TabIndex = 2;
            this.lblBinario.Text = "Binario a Decimal";
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Location = new System.Drawing.Point(43, 120);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(201, 30);
            this.lblDecimal.TabIndex = 3;
            this.lblDecimal.Text = "Decimal A Binario";
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(220, 34);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(147, 26);
            this.txtBinario.TabIndex = 4;
            this.txtBinario.Leave += new System.EventHandler(this.txtBinario_Leave);
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(220, 112);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(147, 26);
            this.txtDecimal.TabIndex = 5;
            this.txtDecimal.Leave += new System.EventHandler(this.txtDecimal_Leave);
            // 
            // txtDecimalABinario
            // 
            this.txtDecimalABinario.Enabled = false;
            this.txtDecimalABinario.Location = new System.Drawing.Point(582, 112);
            this.txtDecimalABinario.Name = "txtDecimalABinario";
            this.txtDecimalABinario.Size = new System.Drawing.Size(178, 26);
            this.txtDecimalABinario.TabIndex = 6;
            // 
            // txtBinarioADecimal
            // 
            this.txtBinarioADecimal.Enabled = false;
            this.txtBinarioADecimal.Location = new System.Drawing.Point(582, 31);
            this.txtBinarioADecimal.Name = "txtBinarioADecimal";
            this.txtBinarioADecimal.Size = new System.Drawing.Size(178, 26);
            this.txtBinarioADecimal.TabIndex = 7;
            // 
            // ConversorNumeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 193);
            this.Controls.Add(this.txtBinarioADecimal);
            this.Controls.Add(this.txtDecimalABinario);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.lblBinario);
            this.Controls.Add(this.btnDecimalABinario);
            this.Controls.Add(this.btnBinarioDecimal);
            this.Name = "ConversorNumeros";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBinarioDecimal;
        private System.Windows.Forms.Button btnDecimalABinario;
        private System.Windows.Forms.Label lblBinario;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtDecimalABinario;
        private System.Windows.Forms.TextBox txtBinarioADecimal;
    }
}

