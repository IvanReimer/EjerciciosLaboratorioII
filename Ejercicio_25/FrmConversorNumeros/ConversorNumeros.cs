using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conversor;
namespace FrmConversorNumeros
{
    public partial class ConversorNumeros : Form
    {
        NumeroBinario binario;
        NumeroDecimal flotante;
        public ConversorNumeros()
        {
            InitializeComponent();
        }

        private void txtBinario_Leave(object sender, EventArgs e)
        {
            if(Conversor.Conversor.isBinary(this.txtBinario.Text))
            {
                binario = this.txtBinario.Text;
            }
            else
            {
                this.txtBinario.Focus();
            }
        }

        private void txtDecimal_Leave(object sender, EventArgs e)
        {
            double numero;
            if (double.TryParse(this.txtDecimal.Text, out numero))
            {
                flotante = numero;
            }
            else
            {
                this.txtDecimal.Focus();
            }
        }

        private void btnBinarioDecimal_Click(object sender, EventArgs e)
        {
            if( ! (binario is null))
            {
                this.txtBinarioADecimal.Text = Conversor.Conversor.BinarioDecimal(binario).ToString();
            }
        }

        private void btnDecimalABinario_Click(object sender, EventArgs e)
        {
            if ( ! (flotante is null) )
            {
                this.txtDecimalABinario.Text = Conversor.Conversor.DecimalBinario(flotante).ToString();
            }
        }
    }
}
