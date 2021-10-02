using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic; 
namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        Producto producto;
        Comiqueria comiqueria;
        public VentasForm()
        {
            InitializeComponent();
        }
        public VentasForm(Producto p, Comiqueria comiqueria) : this()
        {
            this.producto = p;
            this.comiqueria = comiqueria;
        }
        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            int cantidadSeleccionada = (int)this.numericUpDownCantidad.Value;
            this.lblPrecioFinal.Text = String.Format("Precio Final: ${0:0.00}", Venta.CalcularPrecioFinal(this.producto.Precio, cantidadSeleccionada));

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            this.lblDescripcion.Text = producto.Descripcion;
            int cantidadSeleccionada = (int)this.numericUpDownCantidad.Value;
            this.lblPrecioFinal.Text = String.Format("Precio Final: ${0:0.00}", Venta.CalcularPrecioFinal(this.producto.Precio, cantidadSeleccionada));
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (this.producto.Stock >= this.numericUpDownCantidad.Value)
            {
                this.comiqueria.Vender(this.producto, (int)this.numericUpDownCantidad.Value);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Superó la cantidad de unidades a vender", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }



        }
    }
}
