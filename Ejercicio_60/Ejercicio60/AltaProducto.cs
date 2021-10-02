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
using Entidades;
namespace Ejercicio60
{
    public partial class AltaProducto : Form
    {
        Producto pAux;
        public AltaProducto()
        {
            InitializeComponent();
        }
        public Producto DevolverProducto
        {
            get
            {
                return this.pAux;
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            if (this.EstanLosCamposNecesariosLlenos() && this.CamposNoSuperanLaLongitudMaxima() )
            {
                pAux = new Producto();
                this.pAux.nombre = this.tbNombre.Text;
                this.pAux.numeroProducto = this.tbNumeroProducto.Text;
                this.pAux.makeFlag = bool.Parse(this.tbMakeFlag.Text);
                this.pAux.goodFlag = bool.Parse(this.tbFinishedGoodFlag.Text);
                this.pAux.color = this.tbColor.Text;
                this.pAux.safetyStockLevel = Int16.Parse(this.tbSafetyStockLevel.Text);
                this.pAux.reorderPoint = Int16.Parse(this.tbReorderPoint.Text);
                this.pAux.standartCost = decimal.Parse(this.tbStandartCost.Text);
                this.pAux.listPrice = decimal.Parse(this.tbListPrice.Text);
                this.pAux.size = this.tbSize.Text;
                this.pAux.sizeUnitMeasureCode = this.tbSizeMeasureCode.Text;
                this.pAux.weightUnitMeasureCode = this.tbWeightUnitMeasureCode.Text;
                this.pAux.weight = decimal.Parse(this.tbWeight.Text);
                this.pAux.daysToManufacture = int.Parse(this.tbDaysToManufacture.Text);
                this.pAux.productLine = this.tbProductLine.Text;
                this.pAux._class = this.tbClass.Text;
                this.pAux.style = this.tbStyle.Text;
                this.pAux.productSubcategoryID = int.Parse(this.tbProductSubcategoryID.Text);
                this.pAux.productModelID = int.Parse(this.tbProductModelID.Text);
                this.pAux.sellStartDate = DateTime.Parse(this.tbSellStartDate.Text);
                this.pAux.sellEndDate = DateTime.Parse(this.tbSellEndDate.Text);
                this.pAux.discontinuedDate = DateTime.Parse(this.tbDiscontinuedDate.Text);
                this.pAux.modifiedDate = DateTime.Parse(this.tbModifiedDate.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR! Reintentar");
            }
            
        }

        private bool CamposNoSuperanLaLongitudMaxima()
        {
            return true;
        }
        private bool EstanLosCamposNecesariosLlenos()
        {
            return this.tbNombre.Text != String.Empty && this.tbNumeroProducto.Text != String.Empty &&
            this.tbMakeFlag.Text != String.Empty && this.tbFinishedGoodFlag.Text != String.Empty && this.tbSafetyStockLevel.Text != String.Empty &&
            this.tbReorderPoint.Text != String.Empty && this.tbStandartCost.Text != String.Empty && this.tbListPrice.Text != String.Empty &&
            this.tbDaysToManufacture.Text != String.Empty && this.tbSellStartDate.Text != String.Empty && this.tbModifiedDate.Text != String.Empty;
        }
    }
}
