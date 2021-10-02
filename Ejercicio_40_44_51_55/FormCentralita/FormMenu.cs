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
    public partial class FormMenu : Form
    {
        Centralita central;
        FormLlamador llamada;
        FormMostrar mostrador;
        public FormMenu()
        {
            central = new Centralita();
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            llamada = new FormLlamador(central);
            llamada.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (!(central.RutaDeArchivo is null))
            {
                MessageBox.Show(central.Leer(), "Llamadas", MessageBoxButtons.OK);
            }
            Application.Exit();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            central = llamada.MostrarCentralita;
            mostrador = new FormMostrar(central);
            mostrador.TipoDeLlamada = Llamada.TipoLlamada.Todas;
            mostrador.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            central = llamada.MostrarCentralita;
            mostrador = new FormMostrar(central);
            mostrador.TipoDeLlamada = Llamada.TipoLlamada.Local;
            mostrador.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            central = llamada.MostrarCentralita;
            mostrador = new FormMostrar(central);
            mostrador.TipoDeLlamada = Llamada.TipoLlamada.Provincial;
            mostrador.ShowDialog();
            
        }

    }
}
