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
using ControlCantina;
namespace FrmCantina
{
    public partial class FrmCantina : Form
    {
        Botella.Tipo tipo;
        public FrmCantina(int cantidadEspacios)
        {
            InitializeComponent();
            this.barra.SetCantina = new Cantina(cantidadEspacios);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }
        public String GetInforme 
        {
            get
            {
                StringBuilder datosBotellas = new StringBuilder();
                foreach (Botella botella in this.barra.GetCantina.Botellas)
                {
                    datosBotellas.AppendLine(botella);
                }
                return datosBotellas.ToString();
            }
        }
        public Cantina GetCantina
        {
            get
            {
                return this.barra.GetCantina;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.rbAgua.Checked || this.rbCerbeza.Checked )
            {
                if (this.rbCerbeza.Checked)
                {
                    this.barra.AgregarBotella(new Cerveza((int)this.nudCapacidad.Value,this.txtMarca.Text,(int)this.nudContenido.Value));
                }
                else 
                {
                    this.barra.AgregarBotella(new Agua((int)this.nudCapacidad.Value, this.txtMarca.Text, (int)this.nudContenido.Value));
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
