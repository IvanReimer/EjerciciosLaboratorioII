namespace FrmCantina
{
    partial class FrmCantina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCantina));
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rbCerbeza = new System.Windows.Forms.RadioButton();
            this.rbAgua = new System.Windows.Forms.RadioButton();
            this.lblCapacidad = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.nudContenido = new System.Windows.Forms.NumericUpDown();
            this.lblBotella = new System.Windows.Forms.Label();
            this.barra = new ControlCantina.Barra();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(322, 463);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 20);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(326, 502);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(194, 26);
            this.txtMarca.TabIndex = 1;
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(326, 605);
            this.nudCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(81, 26);
            this.nudCapacidad.TabIndex = 2;
            this.nudCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(630, 502);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(143, 28);
            this.cmbBotellaTipo.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(630, 582);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 49);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rbCerbeza
            // 
            this.rbCerbeza.AutoSize = true;
            this.rbCerbeza.Location = new System.Drawing.Point(77, 463);
            this.rbCerbeza.Name = "rbCerbeza";
            this.rbCerbeza.Size = new System.Drawing.Size(92, 24);
            this.rbCerbeza.TabIndex = 5;
            this.rbCerbeza.TabStop = true;
            this.rbCerbeza.Text = "Cerveza";
            this.rbCerbeza.UseVisualStyleBackColor = true;
            // 
            // rbAgua
            // 
            this.rbAgua.AutoSize = true;
            this.rbAgua.Location = new System.Drawing.Point(77, 521);
            this.rbAgua.Name = "rbAgua";
            this.rbAgua.Size = new System.Drawing.Size(72, 24);
            this.rbAgua.TabIndex = 6;
            this.rbAgua.TabStop = true;
            this.rbAgua.Text = "Agua";
            this.rbAgua.UseVisualStyleBackColor = true;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Location = new System.Drawing.Point(322, 560);
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(85, 20);
            this.lblCapacidad.TabIndex = 7;
            this.lblCapacidad.Text = "Capacidad";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Location = new System.Drawing.Point(435, 560);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(82, 20);
            this.lblContenido.TabIndex = 8;
            this.lblContenido.Text = "Contenido";
            // 
            // nudContenido
            // 
            this.nudContenido.Location = new System.Drawing.Point(439, 605);
            this.nudContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudContenido.Name = "nudContenido";
            this.nudContenido.Size = new System.Drawing.Size(81, 26);
            this.nudContenido.TabIndex = 9;
            this.nudContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblBotella
            // 
            this.lblBotella.AutoSize = true;
            this.lblBotella.Location = new System.Drawing.Point(626, 463);
            this.lblBotella.Name = "lblBotella";
            this.lblBotella.Size = new System.Drawing.Size(88, 20);
            this.lblBotella.TabIndex = 10;
            this.lblBotella.Text = "Botella tipo";
            // 
            // barra
            // 
            this.barra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra.BackgroundImage")));
            this.barra.Location = new System.Drawing.Point(1, 2);
            this.barra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(917, 456);
            this.barra.TabIndex = 11;
            // 
            // FrmCantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 657);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.lblBotella);
            this.Controls.Add(this.nudContenido);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblCapacidad);
            this.Controls.Add(this.rbAgua);
            this.Controls.Add(this.rbCerbeza);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbBotellaTipo);
            this.Controls.Add(this.nudCapacidad);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCantina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno Ivan Reimer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rbCerbeza;
        private System.Windows.Forms.RadioButton rbAgua;
        private System.Windows.Forms.Label lblCapacidad;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.NumericUpDown nudContenido;
        private System.Windows.Forms.Label lblBotella;
        private ControlCantina.Barra barra;
    }
}

