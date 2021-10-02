using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace FrmCantina
{
    public partial class FrmBar : Form
    {
        Edificio edificio;
       // FrmCantidadEspaciosCantina cantidadEspacios;
        public FrmBar()
        {
            InitializeComponent();
        }

        private void tsmVentas_Click(object sender, EventArgs e)
        {
            foreach (FrmCantina cantina in this.MdiChildren)
            {
                MessageBox.Show(cantina.GetInforme);
            }
        }

        private void FrmBar_Load(object sender, EventArgs e)
        {
            //cantidadEspacios = new FrmCantidadEspaciosCantina();
            edificio = Edificio.GetBar();
        }

        private void tsmAgregar_Click(object sender, EventArgs e)
        {
            FrmCantidadEspaciosCantina cantidadEspacios = new FrmCantidadEspaciosCantina();
            cantidadEspacios.ShowDialog();
            if (cantidadEspacios.DialogResult == DialogResult.OK)
            {
                FrmCantina frmCantina = new FrmCantina(cantidadEspacios.CantidadEspacios);
                if (this.edificio + frmCantina.GetCantina )
                {
                    frmCantina.MdiParent = this;
                    frmCantina.Show();
                }
            }           
            
            
        }
    }
}
