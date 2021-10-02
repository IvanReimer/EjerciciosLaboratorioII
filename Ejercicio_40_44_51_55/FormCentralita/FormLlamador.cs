using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;
namespace FormCentralita
{
    public partial class FormLlamador : Form
    {
        Centralita central;
        Random duracionLlamada = new Random();
        Random costo = new Random();
        Llamada llamada;
        TextBox auxText = new TextBox();

        public FormLlamador(Centralita central)
        {
            this.central = central;
            InitializeComponent();            
        }
        public Centralita MostrarCentralita 
        {
            get
            {
                return central;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = "Nro Destino";
            this.txtNroOrigen.Text = "Nro Origen";
            this.cmbFranja.Text = "Franja";
            this.cmbFranja.Enabled = false;
            auxText = this.txtNroOrigen;
        }
        #region Botones Panel
        private void btn1_Click(object sender, EventArgs e)
        {
            if (auxText == this.txtNroOrigen)
            {
                if (this.txtNroOrigen.Text.Contains("Nro Origen"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroOrigen.Text = "1";

                }
                else
                {
                    this.txtNroOrigen.Text += "1";
                }
                
            }
            else if (auxText == this.txtNroDestino)
            {
                if (this.txtNroDestino.Text.Contains("Nro Destino"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroDestino.Text = "1";
                }
                else
                {
                    this.txtNroDestino.Text += "1";
                }
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (auxText == this.txtNroOrigen)
            {
                if (this.txtNroOrigen.Text.Contains("Nro Origen"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroOrigen.Text = "2";

                }
                else
                {
                    this.txtNroOrigen.Text += "2";
                }

            }
            else if (auxText == this.txtNroDestino)
            {
                if (this.txtNroDestino.Text.Contains("Nro Destino"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroDestino.Text = "2";
                }
                else
                {
                    this.txtNroDestino.Text += "2";
                }
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (auxText == this.txtNroOrigen)
            {
                if (this.txtNroOrigen.Text.Contains("Nro Origen"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroOrigen.Text = "3";

                }
                else
                {
                    this.txtNroOrigen.Text += "3";
                }

            }
            else if (auxText == this.txtNroDestino)
            {
                if (this.txtNroDestino.Text.Contains("Nro Destino"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroDestino.Text = "3";
                }
                else
                {
                    this.txtNroDestino.Text += "3";
                }
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (auxText == this.txtNroOrigen)
            {
                if (this.txtNroOrigen.Text.Contains("Nro Origen"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroOrigen.Text = "4";

                }
                else
                {
                    this.txtNroOrigen.Text += "4";
                }

            }
            else if (auxText == this.txtNroDestino)
            {
                if (this.txtNroDestino.Text.Contains("Nro Destino"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroDestino.Text = "4";
                }
                else
                {
                    this.txtNroDestino.Text += "4";
                }
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (auxText == this.txtNroOrigen)
            {
                if (this.txtNroOrigen.Text.Contains("Nro Origen"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroOrigen.Text = "5";

                }
                else
                {
                    this.txtNroOrigen.Text += "5";
                }

            }
            else if (auxText == this.txtNroDestino)
            {
                if (this.txtNroDestino.Text.Contains("Nro Destino"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroDestino.Text = "5";
                }
                else
                {
                    this.txtNroDestino.Text += "5";
                }
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (auxText == this.txtNroOrigen)
            {
                if (this.txtNroOrigen.Text.Contains("Nro Origen"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroOrigen.Text = "6";

                }
                else
                {
                    this.txtNroOrigen.Text += "6";
                }

            }
            else if (auxText == this.txtNroDestino)
            {
                if (this.txtNroDestino.Text.Contains("Nro Destino"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroDestino.Text = "6";
                }
                else
                {
                    this.txtNroDestino.Text += "6";
                }
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (auxText == this.txtNroOrigen)
            {
                if (this.txtNroOrigen.Text.Contains("Nro Origen"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroOrigen.Text = "7";

                }
                else
                {
                    this.txtNroOrigen.Text += "7";
                }

            }
            else if (auxText == this.txtNroDestino)
            {
                if (this.txtNroDestino.Text.Contains("Nro Destino"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroDestino.Text = "7";
                }
                else
                {
                    this.txtNroDestino.Text += "7";
                }
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (auxText == this.txtNroOrigen)
            {
                if (this.txtNroOrigen.Text.Contains("Nro Origen"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroOrigen.Text = "8";

                }
                else
                {
                    this.txtNroOrigen.Text += "8";
                }

            }
            else if (auxText == this.txtNroDestino)
            {
                if (this.txtNroDestino.Text.Contains("Nro Destino"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroDestino.Text = "8";
                }
                else
                {
                    this.txtNroDestino.Text += "8";
                }
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (auxText == this.txtNroOrigen)
            {
                if (this.txtNroOrigen.Text.Contains("Nro Origen"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroOrigen.Text = "9";

                }
                else
                {
                    this.txtNroOrigen.Text += "9";
                }

            }
            else if (auxText == this.txtNroDestino)
            {
                if (this.txtNroDestino.Text.Contains("Nro Destino"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroDestino.Text = "9";
                }
                else
                {
                    this.txtNroDestino.Text += "9";
                }
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (auxText == this.txtNroOrigen)
            {
                if (this.txtNroOrigen.Text.Contains("Nro Origen"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroOrigen.Text = "0";

                }
                else
                {
                    this.txtNroOrigen.Text += "0";
                }

            }
            else if (auxText == this.txtNroDestino)
            {
                if (this.txtNroDestino.Text.Contains("Nro Destino"))
                {
                    this.cmbFranja.Enabled = false;
                    this.txtNroDestino.Text = "0";
                }
                else
                {
                    this.txtNroDestino.Text += "0";
                }
            }
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {

            if (auxText == this.txtNroOrigen)
            {
                if (this.txtNroOrigen.Text.Contains("Nro Origen"))
                {
                    this.txtNroOrigen.Text = "*";
                    this.cmbFranja.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Solo se puede agregar \"*\" al principio de la llamada", "ERROR", MessageBoxButtons.OK);
                }

            }
            else if (auxText == this.txtNroDestino)
            {
                if (this.txtNroDestino.Text.Contains("Nro Destino"))
                {
                    this.txtNroDestino.Text = "*";
                    this.cmbFranja.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Solo se puede agregar \"*\" al principio de la llamada", "ERROR", MessageBoxButtons.OK);
                }
            }

        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            if (auxText == this.txtNroOrigen)
            {
                if (this.txtNroOrigen.Text.Contains("Nro Origen"))
                {
                    this.txtNroOrigen.Text = "#";
                    this.cmbFranja.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Solo se puede agregar \"#\" al principio de la llamada", "ERROR", MessageBoxButtons.OK);
                }

            }
            else if (auxText == this.txtNroDestino)
            {
                if (this.txtNroDestino.Text.Contains("Nro Destino"))
                {
                    this.txtNroDestino.Text = "#";
                    this.cmbFranja.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Solo se puede agregar \"#\" al principio de la llamada", "ERROR", MessageBoxButtons.OK);
                }
            }

        }
        #endregion
        
        private void txtNroOrigen_Enter(object sender, EventArgs e)
        {
            auxText = this.txtNroOrigen;
        }


        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (this.SePuedeLlamar())
            {
                central.RutaDeArchivo = "bitacora.txt";
                if (this.txtNroDestino.Text.StartsWith("#"))
                {
                    Provincial.Franja franjas;
                    Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
                    llamada = new Provincial(this.txtNroOrigen.Text, franjas, duracionLlamada.Next(1, 50), this.txtNroDestino.Text);
                    try
                    {
                        central += llamada;
                    }
                    catch (CentralitaExcepcion error)
                    {
                        MessageBox.Show(error.Message);
                    }
                    MessageBox.Show("Se realizo una llamada provincial");
                }
                else
                {
                    llamada = new Local(this.txtNroOrigen.Text, duracionLlamada.Next(1, 50), this.txtNroDestino.Text, (float)(costo.NextDouble() * (5.6-0.5) + 0.5));
                    try
                    {
                        central += llamada;
                    }
                    catch (CentralitaExcepcion error)
                    {
                        MessageBox.Show(error.Message);
                    }
                    MessageBox.Show("Se realizo una llamada local");
                }
            }
            else
            {
                MessageBox.Show("No se pudo realizar la llamada, intente ingresar numeros en destino y origen para realizarla.");
            }
            
            
        }
        private bool EsValidoElNumeroDestino()
        {
            return !this.txtNroDestino.Text.Contains("Nro Destino");
        }
        private bool EsValidoElNumeroDeOrigen()
        {
            return !this.txtNroOrigen.Text.Contains("Nro Origen");
        }
        private bool SePuedeLlamar()
        {
            return this.EsValidoElNumeroDeOrigen() && this.EsValidoElNumeroDestino();
        }

        private void FormLlamador_Load(object sender, EventArgs e)
        {
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            auxText = this.txtNroOrigen;
        }

        private void txtNroDestino_Enter(object sender, EventArgs e)
        {
            auxText = this.txtNroDestino;
        }
    }
}
