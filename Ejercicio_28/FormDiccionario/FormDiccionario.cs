using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diccionarios;
namespace FormDiccionario
{
    public partial class FormDiccionario : Form
    {
        Diccionario palabras;
        public FormDiccionario()
        {
            InitializeComponent();
            palabras = new Diccionario();
        }

        private void calculadorDePalabras_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            String[] separadores = {" ","\n",".","?",",",":","¿","¡","'","!","-"};
            String [] palabrasSeparadas = rchTxtBox.Text.Split(separadores,StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in palabrasSeparadas)
            {
                palabras.AgregarPalabra(item);
            }
            String [] top3 = palabras.ObtenerTop3PalabrasConMasApariciones(palabras);
            foreach (String item in top3)
            {
                sb.AppendLine(item);
            }


            MessageBox.Show(sb.ToString(), "Palabras con mas apariciones", MessageBoxButtons.OK);



            //MessageBox.Show(palabras.Count.ToString(),"Cantidad de palabras",MessageBoxButtons.OK);
        }
    }
}
