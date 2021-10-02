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
    public partial class FormMostrar : Form
    {
        Centralita central;
        Llamada.TipoLlamada tipo;
        public FormMostrar(Centralita central)
        {
            InitializeComponent();
            this.central = central;
        }
        public Llamada.TipoLlamada TipoDeLlamada
        { 
            set
            {
                this.tipo = value;
            }
        }
        private void FormMostrar_Load(object sender, EventArgs e)
        {
            foreach (Llamada call in central.Llamadas)
            {
                switch (this.tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (call is Local)
                        {
                            this.rtbMostrar.Text = ((Local)call).ToString();
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (call is Provincial)
                        {
                            this.rtbMostrar.Text = ((Provincial)call).ToString();
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        central.OrdenarLlamadas();
                        this.rtbMostrar.Text = central.ToString();
                        break;
                }
            }
        }
    }
}
