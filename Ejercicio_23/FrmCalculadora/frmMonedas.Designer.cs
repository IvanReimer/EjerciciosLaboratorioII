namespace FrmCalculadora
{
    partial class frmMonedas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonedas));
            this.lblEuroA = new System.Windows.Forms.Label();
            this.lblDolarA = new System.Windows.Forms.Label();
            this.lblPesoA = new System.Windows.Forms.Label();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.btnConvertirEuro = new System.Windows.Forms.Button();
            this.btnConvertirDolar = new System.Windows.Forms.Button();
            this.btnConvertirPeso = new System.Windows.Forms.Button();
            this.btnLockCotizacion = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionPeso = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEuroA
            // 
            this.lblEuroA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuroA.Location = new System.Drawing.Point(44, 158);
            this.lblEuroA.Name = "lblEuroA";
            this.lblEuroA.Size = new System.Drawing.Size(116, 40);
            this.lblEuroA.TabIndex = 0;
            this.lblEuroA.Text = "Euro";
            this.lblEuroA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDolarA
            // 
            this.lblDolarA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolarA.Location = new System.Drawing.Point(44, 245);
            this.lblDolarA.Name = "lblDolarA";
            this.lblDolarA.Size = new System.Drawing.Size(116, 40);
            this.lblDolarA.TabIndex = 1;
            this.lblDolarA.Text = "Dólar";
            this.lblDolarA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPesoA
            // 
            this.lblPesoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoA.Location = new System.Drawing.Point(44, 337);
            this.lblPesoA.Name = "lblPesoA";
            this.lblPesoA.Size = new System.Drawing.Size(116, 40);
            this.lblPesoA.TabIndex = 2;
            this.lblPesoA.Text = "Peso";
            this.lblPesoA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCotizacion.Location = new System.Drawing.Point(191, 36);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(117, 40);
            this.lblCotizacion.TabIndex = 3;
            this.lblCotizacion.Text = "Cotización";
            this.lblCotizacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEuro
            // 
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(515, 118);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(100, 30);
            this.lblEuro.TabIndex = 4;
            this.lblEuro.Text = "Euro";
            this.lblEuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDolar
            // 
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(641, 118);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(100, 30);
            this.lblDolar.TabIndex = 5;
            this.lblDolar.Text = "Dólar";
            this.lblDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConvertirEuro
            // 
            this.btnConvertirEuro.Location = new System.Drawing.Point(363, 158);
            this.btnConvertirEuro.Name = "btnConvertirEuro";
            this.btnConvertirEuro.Size = new System.Drawing.Size(120, 40);
            this.btnConvertirEuro.TabIndex = 7;
            this.btnConvertirEuro.Text = "->";
            this.btnConvertirEuro.UseVisualStyleBackColor = true;
            this.btnConvertirEuro.Click += new System.EventHandler(this.btnConvertirEuro_Click);
            // 
            // btnConvertirDolar
            // 
            this.btnConvertirDolar.Location = new System.Drawing.Point(363, 245);
            this.btnConvertirDolar.Name = "btnConvertirDolar";
            this.btnConvertirDolar.Size = new System.Drawing.Size(120, 40);
            this.btnConvertirDolar.TabIndex = 8;
            this.btnConvertirDolar.Text = "->";
            this.btnConvertirDolar.UseVisualStyleBackColor = true;
            this.btnConvertirDolar.Click += new System.EventHandler(this.btnConvertirDolar_Click);
            // 
            // btnConvertirPeso
            // 
            this.btnConvertirPeso.Location = new System.Drawing.Point(363, 337);
            this.btnConvertirPeso.Name = "btnConvertirPeso";
            this.btnConvertirPeso.Size = new System.Drawing.Size(120, 40);
            this.btnConvertirPeso.TabIndex = 9;
            this.btnConvertirPeso.Text = "->";
            this.btnConvertirPeso.UseVisualStyleBackColor = true;
            this.btnConvertirPeso.Click += new System.EventHandler(this.btnConvertirPeso_Click);
            // 
            // btnLockCotizacion
            // 
            this.btnLockCotizacion.ImageIndex = 1;
            this.btnLockCotizacion.ImageList = this.imageList;
            this.btnLockCotizacion.Location = new System.Drawing.Point(363, 36);
            this.btnLockCotizacion.Name = "btnLockCotizacion";
            this.btnLockCotizacion.Size = new System.Drawing.Size(120, 40);
            this.btnLockCotizacion.TabIndex = 10;
            this.btnLockCotizacion.UseVisualStyleBackColor = true;
            this.btnLockCotizacion.Click += new System.EventHandler(this.btnLockCotizacion_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "bloqueado.png");
            this.imageList.Images.SetKeyName(1, "desbloqueado.png");
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Enabled = false;
            this.txtDolarAPeso.Location = new System.Drawing.Point(776, 245);
            this.txtDolarAPeso.Multiline = true;
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.Size = new System.Drawing.Size(100, 40);
            this.txtDolarAPeso.TabIndex = 11;
            this.txtDolarAPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Enabled = false;
            this.txtDolarADolar.Location = new System.Drawing.Point(641, 245);
            this.txtDolarADolar.Multiline = true;
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(100, 40);
            this.txtDolarADolar.TabIndex = 12;
            this.txtDolarADolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Enabled = false;
            this.txtDolarAEuro.Location = new System.Drawing.Point(515, 245);
            this.txtDolarAEuro.Multiline = true;
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(100, 40);
            this.txtDolarAEuro.TabIndex = 13;
            this.txtDolarAEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Enabled = false;
            this.txtEuroAPeso.Location = new System.Drawing.Point(776, 158);
            this.txtEuroAPeso.Multiline = true;
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.Size = new System.Drawing.Size(100, 37);
            this.txtEuroAPeso.TabIndex = 14;
            this.txtEuroAPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Enabled = false;
            this.txtEuroADolar.Location = new System.Drawing.Point(641, 158);
            this.txtEuroADolar.Multiline = true;
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(100, 40);
            this.txtEuroADolar.TabIndex = 15;
            this.txtEuroADolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Enabled = false;
            this.txtEuroAEuro.Location = new System.Drawing.Point(515, 158);
            this.txtEuroAEuro.Multiline = true;
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(100, 40);
            this.txtEuroAEuro.TabIndex = 16;
            this.txtEuroAEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Enabled = false;
            this.txtPesoAEuro.Location = new System.Drawing.Point(519, 337);
            this.txtPesoAEuro.Multiline = true;
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.Size = new System.Drawing.Size(100, 40);
            this.txtPesoAEuro.TabIndex = 17;
            this.txtPesoAEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Enabled = false;
            this.txtPesoADolar.Location = new System.Drawing.Point(641, 337);
            this.txtPesoADolar.Multiline = true;
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.Size = new System.Drawing.Size(100, 40);
            this.txtPesoADolar.TabIndex = 18;
            this.txtPesoADolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Enabled = false;
            this.txtPesoAPeso.Location = new System.Drawing.Point(776, 337);
            this.txtPesoAPeso.Multiline = true;
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.Size = new System.Drawing.Size(100, 40);
            this.txtPesoAPeso.TabIndex = 19;
            this.txtPesoAPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPeso
            // 
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPeso.Location = new System.Drawing.Point(772, 118);
            this.lblPeso.Margin = new System.Windows.Forms.Padding(0);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(100, 30);
            this.lblPeso.TabIndex = 6;
            this.lblPeso.Text = "Peso";
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Location = new System.Drawing.Point(515, 36);
            this.txtCotizacionEuro.Multiline = true;
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(100, 40);
            this.txtCotizacionEuro.TabIndex = 20;
            this.txtCotizacionEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCotizacionEuro.Leave += new System.EventHandler(this.txtCotizacionEuro_Leave);
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Location = new System.Drawing.Point(641, 36);
            this.txtCotizacionDolar.Multiline = true;
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(100, 40);
            this.txtCotizacionDolar.TabIndex = 21;
            this.txtCotizacionDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCotizacionDolar.Leave += new System.EventHandler(this.txtCotizacionDolar_Leave);
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.Location = new System.Drawing.Point(776, 36);
            this.txtCotizacionPeso.Multiline = true;
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(100, 40);
            this.txtCotizacionPeso.TabIndex = 22;
            this.txtCotizacionPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCotizacionPeso.Leave += new System.EventHandler(this.txtCotizacionPeso_Leave);
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(191, 158);
            this.txtEuro.Multiline = true;
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(117, 40);
            this.txtEuro.TabIndex = 23;
            this.txtEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEuro.Leave += new System.EventHandler(this.txtEuro_Leave);
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(191, 245);
            this.txtDolar.Multiline = true;
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(117, 40);
            this.txtDolar.TabIndex = 24;
            this.txtDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDolar.Leave += new System.EventHandler(this.txtDolar_Leave);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(191, 337);
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(117, 40);
            this.txtPeso.TabIndex = 25;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPeso.Leave += new System.EventHandler(this.txtPeso_Leave);
            // 
            // frmMonedas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 518);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.btnLockCotizacion);
            this.Controls.Add(this.btnConvertirPeso);
            this.Controls.Add(this.btnConvertirDolar);
            this.Controls.Add(this.btnConvertirEuro);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.lblPesoA);
            this.Controls.Add(this.lblDolarA);
            this.Controls.Add(this.lblEuroA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMonedas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 23";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEuroA;
        private System.Windows.Forms.Label lblDolarA;
        private System.Windows.Forms.Label lblPesoA;
        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Button btnConvertirEuro;
        private System.Windows.Forms.Button btnConvertirDolar;
        private System.Windows.Forms.Button btnConvertirPeso;
        private System.Windows.Forms.Button btnLockCotizacion;
        private System.Windows.Forms.TextBox txtDolarAPeso;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtEuroAPeso;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtPesoAEuro;
        private System.Windows.Forms.TextBox txtPesoADolar;
        private System.Windows.Forms.TextBox txtPesoAPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtCotizacionEuro;
        private System.Windows.Forms.TextBox txtCotizacionDolar;
        private System.Windows.Forms.TextBox txtCotizacionPeso;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtPeso;
    }
}

