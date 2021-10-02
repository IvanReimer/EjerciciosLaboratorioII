using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class FrmPickUp : Form
    {
        public FrmPickUp()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            PickUp p = new PickUp(this.txtPatente.Text, this.txtModelo.Text);
            MessageBox.Show(p.ConsultarDatos(),"Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
