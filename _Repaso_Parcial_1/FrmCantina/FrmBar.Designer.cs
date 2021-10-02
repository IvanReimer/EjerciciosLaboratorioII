namespace FrmCantina
{
    partial class FrmBar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StripMenu = new System.Windows.Forms.MenuStrip();
            this.smCantina = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StripMenu
            // 
            this.StripMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.StripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.StripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smCantina});
            this.StripMenu.Location = new System.Drawing.Point(0, 0);
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Size = new System.Drawing.Size(1200, 54);
            this.StripMenu.TabIndex = 1;
            this.StripMenu.Text = "menuStrip1";
            // 
            // smCantina
            // 
            this.smCantina.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregar,
            this.tsmVentas});
            this.smCantina.Name = "smCantina";
            this.smCantina.Size = new System.Drawing.Size(87, 50);
            this.smCantina.Text = "Cantina";
            // 
            // tsmAgregar
            // 
            this.tsmAgregar.Name = "tsmAgregar";
            this.tsmAgregar.Size = new System.Drawing.Size(178, 34);
            this.tsmAgregar.Text = "Agregar";
            this.tsmAgregar.Click += new System.EventHandler(this.tsmAgregar_Click);
            // 
            // tsmVentas
            // 
            this.tsmVentas.Name = "tsmVentas";
            this.tsmVentas.Size = new System.Drawing.Size(178, 34);
            this.tsmVentas.Text = "Ventas";
            this.tsmVentas.Click += new System.EventHandler(this.tsmVentas_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.barrasToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 68);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(148, 32);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // barrasToolStripMenuItem
            // 
            this.barrasToolStripMenuItem.Name = "barrasToolStripMenuItem";
            this.barrasToolStripMenuItem.Size = new System.Drawing.Size(148, 32);
            this.barrasToolStripMenuItem.Text = "Barras";
            // 
            // FrmBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StripMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.StripMenu;
            this.Name = "FrmBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "El bar de Ivan Reimer";
            this.Load += new System.EventHandler(this.FrmBar_Load);
            this.StripMenu.ResumeLayout(false);
            this.StripMenu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip StripMenu;
        private System.Windows.Forms.ToolStripMenuItem smCantina;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregar;
        private System.Windows.Forms.ToolStripMenuItem tsmVentas;
    }
}