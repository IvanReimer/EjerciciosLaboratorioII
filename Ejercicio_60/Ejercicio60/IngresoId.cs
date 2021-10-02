using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio60
{
    public partial class IngresoId : Form
    {
        SqlCommand miComando;
        SqlConnection miConexion;
        SqlDataReader miLector;
        public IngresoId(SqlConnection conexion, SqlCommand comando, SqlDataReader lector)
        {
            InitializeComponent();
            this.miComando = comando;
            this.miConexion = conexion;
            this.miLector = lector;
        }
        public int Id
        {
            get
            {
                return int.Parse(this.tbId.Text);
            }
        }
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (this.tbId.Text != String.Empty && this.CoincideElIdConElIdDeBBDD())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Id no coincide con los ids de la base de datos.");
            }
        }

        private bool CoincideElIdConElIdDeBBDD()
        {
            bool idCoincide= false;
            try
            {
                this.miComando.Connection =  this.miConexion;
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = "SELECT ProductID FROM Production.Product";
                this.miConexion.Open();
                this.miLector = this.miComando.ExecuteReader();
                while (this.miLector.Read())
                {
                    if (this.tbId.Text == this.miLector["ProductID"].ToString())
                    {
                        idCoincide = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.miConexion.Close();
            }
            return idCoincide;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
