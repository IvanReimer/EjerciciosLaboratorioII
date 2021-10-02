using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Temperaturas;
namespace Ejercicio_24
{
    public partial class FrmCoversorTemperatura : Form
    {
        Kelvin kelvin;
        Fahrenheit fahrenheit;
        Celsius celsius;

        #region Constructores
        public FrmCoversorTemperatura()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos Leave
        private void txtFahrenheit_Leave(object sender, EventArgs e)
        {
            double temperatura;
            if (double.TryParse(txtFahrenheit.Text, out temperatura))
            {
                fahrenheit = temperatura;
            }
            else
            {
                this.txtFahrenheit.Focus();
            }
        }

        private void txtCelsius_Leave(object sender, EventArgs e)
        {
            double temperatura;
            if (double.TryParse(txtCelsius.Text, out temperatura))
            {
                celsius = temperatura;
            }
            else
            {
                this.txtCelsius.Focus();
            }
        }
        private void txtKelvin_Leave(object sender, EventArgs e)
        {
            double temperatura;
            if (double.TryParse(txtKelvin.Text, out temperatura))
            {
                kelvin = temperatura;
            }
            else
            {
                this.txtKelvin.Focus();
            }
        }


        #endregion

        private void btnConvertirFahrenheit_Click(object sender, EventArgs e)
        {
            double temperatura;
            if (double.TryParse(txtFahrenheit.Text, out temperatura))
            {
                this.txtFahrenheitACelsius.Text = ((Celsius)fahrenheit).GetCantidad().ToString();
                this.txtFahrenheitAFahrenheit.Text = fahrenheit.GetCantidad().ToString();
                this.txtFahrenheitAKelvin.Text = ((Kelvin)fahrenheit).GetCantidad().ToString();

            }
        }

        private void btnConvertirCelsius_Click(object sender, EventArgs e)
        {
            double temperatura;
            if (double.TryParse(txtCelsius.Text, out temperatura))
            {
                this.txtCelsiusACelsius.Text = celsius.GetCantidad().ToString();
                this.txtCelsiusAFahrenheit.Text = ((Fahrenheit)celsius).GetCantidad().ToString();
                this.txtCelsiusAKelvin.Text = ((Kelvin)celsius).GetCantidad().ToString();

            }
        }

        private void btnConvertirKelvin_Click(object sender, EventArgs e)
        {
            double temperatura;
            if (double.TryParse(txtKelvin.Text, out temperatura))
            {
                this.txtKelvinACelsius.Text = ((Celsius)kelvin).GetCantidad().ToString();
                this.txtKelvinAFahrenheit.Text = ((Fahrenheit)kelvin).GetCantidad().ToString();
                this.txtKelvinAKelvin.Text = kelvin.GetCantidad().ToString();

            }
        }

        private void txtFahrenheitAFahrenheit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
