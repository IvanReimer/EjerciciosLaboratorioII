using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;
namespace FrmCalculadora
{
    public partial class frmMonedas : Form
    {
        Dolar dolar;
        Pesos peso;
        Euro euro;
        public frmMonedas()
        {
            InitializeComponent();
            this.btnLockCotizacion.ImageIndex = 1;
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (this.btnLockCotizacion.ImageIndex == 1)
            {
                this.btnLockCotizacion.ImageIndex = 0;
                this.txtCotizacionDolar.Enabled = false;
                this.txtCotizacionPeso.Enabled = false;
                this.txtCotizacionEuro.Enabled = false;
            }
            else
            {
                this.btnLockCotizacion.ImageIndex = 1;
                this.txtCotizacionDolar.Enabled = true;
                this.txtCotizacionPeso.Enabled = true;
                this.txtCotizacionEuro.Enabled = true;
            }


        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double cotizacion;
            if (double.TryParse(this.txtCotizacionEuro.Text, out cotizacion ) )
            {
                Euro.SetCotizacion(cotizacion);
            }
            else
            {
                this.txtCotizacionEuro.Focus();
            }
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            double cotizacion;
            if (double.TryParse(this.txtCotizacionDolar.Text, out cotizacion))
            {
                Dolar.SetCotizacion(cotizacion);
            }
            else
            {
                this.txtCotizacionDolar.Focus();
            }
        }
        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {
            double cotizacion;
            if (double.TryParse(this.txtCotizacionPeso.Text, out cotizacion))
            {
                Pesos.SetCotizacion(cotizacion);
            }
            else
            {
                this.txtCotizacionPeso.Focus();
            }
        }

        private void txtEuro_Leave(object sender, EventArgs e)
        {
            double cantidad;
            if (double.TryParse(this.txtEuro.Text, out cantidad))
            {
                euro = cantidad;
            }
            else
            {
                this.txtEuro.Focus();
            }
        }

        private void txtDolar_Leave(object sender, EventArgs e)
        {
            double cantidad;
            if (double.TryParse(this.txtDolar.Text, out cantidad))
            {
                dolar = cantidad;
            }
            else
            {
                this.txtDolar.Focus();
            }
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            double cantidad;
            if (double.TryParse(this.txtPeso.Text, out cantidad))
            {
                peso = cantidad;
            }
            else
            {
                this.txtPeso.Focus();
            }
        }

        private void btnConvertirEuro_Click(object sender, EventArgs e)
        {
            double cantidadEuros;
            if ( double.TryParse(this.txtEuro.Text, out cantidadEuros) )
            {
                this.txtEuroAEuro.Text = cantidadEuros.ToString();

                this.txtEuroADolar.Text = ((Dolar)euro).GetCantidad().ToString("0.00");

                this.txtEuroAPeso.Text = ((Pesos)euro).GetCantidad().ToString("0.00");
            }
        }
        private void btnConvertirDolar_Click(object sender, EventArgs e)
        {
            double cantidadDolares;
            if (double.TryParse(this.txtDolar.Text, out cantidadDolares))
            {
                this.txtDolarADolar.Text = cantidadDolares.ToString();

                this.txtDolarAEuro.Text = (((Euro)dolar).GetCantidad()).ToString("0.00");

                this.txtDolarAPeso.Text = (((Pesos)dolar).GetCantidad()).ToString("0.00");
            }
        }
        private void btnConvertirPeso_Click(object sender, EventArgs e)
        {
            double cantidadPesos;
            if (double.TryParse(this.txtPeso.Text, out cantidadPesos))
            {
                this.txtPesoAPeso.Text = cantidadPesos.ToString();
                this.txtPesoADolar.Text = (((Dolar)peso).GetCantidad()).ToString("0.00");
                this.txtPesoAEuro.Text = (((Euro)peso).GetCantidad()).ToString("0.00");
            }
        }


    }
    
}

