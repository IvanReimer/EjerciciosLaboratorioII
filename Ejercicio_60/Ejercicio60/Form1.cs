using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entidades;
namespace Ejercicio60
{
    public partial class AdventureWorks : Form
    {
        SqlConnection miConexion;
        SqlCommand miComando;
        DataTable tabla;
        SqlDataReader lectorBasesDeDatos;
        public AdventureWorks()
        {
            InitializeComponent();
            miConexion = new SqlConnection("Data source= localhost ; Database = AdventureWorks2017; Trusted_Connection=True");
            miComando = new SqlCommand();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvBaseDeDatos.RowHeadersVisible = false;
            dgvBaseDeDatos.AllowUserToAddRows = false;
            //dgvBaseDeDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            Producto producto=null;
            AltaProducto alta = new AltaProducto();
            if (alta.ShowDialog() == DialogResult.OK)
            {
                producto = alta.DevolverProducto;
                try
                {
                    miConexion.Open();
                    miComando.Connection = miConexion;
                    miComando.CommandType = CommandType.Text;
                    miComando.CommandText = "INSERT INTO Production.Product(Name,ProductNumber,MakeFlag,FinishedGoodsFlag ,Color," +
                                            "SafetyStockLevel,ReorderPoint,StandardCost,ListPrice,Size,SizeUnitMeasureCode,WeightUnitMeasureCode," +
                                            "Weight,DaysToManufacture,ProductLine,Class,Style,ProductSubcategoryID,ProductModelID,SellStartDate,SellEndDate," +
                                            "DiscontinuedDate,rowguid,ModifiedDate) VALUES (@nombre,@numeroProducto,@makeFlag,@finishedFlag," +
                                            "@color,@stock,@point,@costo,@precioDeLista,@size,@unidadDimension,@pesoUnidad,@peso,@diasManufactura," +
                                            "@linea,@clase,@estilo,@subcategoria,@modelo,@inicioVenta,@finVenta,@discontinuada,@grid,@modificacion)";
                    miComando.Parameters.Clear();
                    //miComando.Parameters.Add(new SqlParameter("id", producto.idProducto));
                    miComando.Parameters.Add(new SqlParameter("nombre", producto.nombre));
                    miComando.Parameters.Add(new SqlParameter("numeroProducto", producto.numeroProducto));
                    miComando.Parameters.Add(new SqlParameter("makeFlag", producto.makeFlag));
                    miComando.Parameters.Add(new SqlParameter("finishedFlag", producto.goodFlag));
                    miComando.Parameters.Add(new SqlParameter("color", producto.color));
                    miComando.Parameters.Add(new SqlParameter("stock", producto.safetyStockLevel));
                    miComando.Parameters.Add(new SqlParameter("point", producto.reorderPoint));
                    miComando.Parameters.Add(new SqlParameter("costo", producto.standartCost));
                    miComando.Parameters.Add(new SqlParameter("precioDeLista", producto.listPrice));
                    miComando.Parameters.Add(new SqlParameter("size", producto.size));
                    miComando.Parameters.Add(new SqlParameter("unidadDimension", producto.sizeUnitMeasureCode));
                    miComando.Parameters.Add(new SqlParameter("pesoUnidad", producto.weightUnitMeasureCode));
                    miComando.Parameters.Add(new SqlParameter("peso", producto.weight));
                    miComando.Parameters.Add(new SqlParameter("diasManufactura", producto.daysToManufacture));
                    miComando.Parameters.Add(new SqlParameter("linea", producto.productLine));
                    miComando.Parameters.Add(new SqlParameter("clase", producto._class));
                    miComando.Parameters.Add(new SqlParameter("estilo", producto.style));
                    miComando.Parameters.Add(new SqlParameter("subcategoria", producto.productSubcategoryID));
                    miComando.Parameters.Add(new SqlParameter("modelo", producto.productModelID));
                    miComando.Parameters.Add(new SqlParameter("inicioVenta", producto.sellStartDate));
                    miComando.Parameters.Add(new SqlParameter("finVenta", producto.sellEndDate));
                    miComando.Parameters.Add(new SqlParameter("discontinuada", producto.discontinuedDate));//
                    miComando.Parameters.Add(new SqlParameter("grid", new Guid()));//
                    miComando.Parameters.Add(new SqlParameter("modificacion", producto.modifiedDate));//
                    miComando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    miConexion.Close();
                }
            }

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                miConexion.Open();
                miComando.Connection = miConexion;
                miComando.CommandType = CommandType.Text;
                miComando.CommandText = "SELECT * FROM Production.Product";
                lectorBasesDeDatos = miComando.ExecuteReader();
                tabla = new DataTable();
                tabla.Load(lectorBasesDeDatos);
                dgvBaseDeDatos.DataSource = tabla;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                miConexion.Close();
            }

        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            IngresoId nuevoIngreso = new IngresoId(this.miConexion, this.miComando, this.lectorBasesDeDatos);
            AltaProducto alta = new AltaProducto();
            Producto producto = null;
            if (nuevoIngreso.ShowDialog() == DialogResult.OK && alta.ShowDialog() == DialogResult.OK)
            {
                producto = alta.DevolverProducto;
                producto.idProducto = nuevoIngreso.Id;
                try
                {
                    this.miConexion.Open();
                    this.miComando.Connection = miConexion;
                    this.miComando.CommandType = CommandType.Text;
                    this.miComando.CommandText = "UPDATE Production.Product SET Name=@nombre, ProductNumber = @numeroProducto ,"+
                                                 "MakeFlag = @makeFlag,FinishedGoodsFlag = @finishedFlag,Color = @color," +
                                                 "SafetyStockLevel = @stock,ReorderPoint =@point,StandardCost = @costo,"+
                                                 "ListPrice = @precioDeLista,Size = @size,SizeUnitMeasureCode = @unidadDimension,"+
                                                 "WeightUnitMeasureCode =@pesoUnidad, Weight = @peso,DaysToManufacture = @diasManufactura,"+
                                                 "ProductLine = @linea,Class = @clase,Style=@estilo,ProductSubcategoryID = @subcategoria ,"+
                                                 "ProductModelID = @modelo,SellStartDate = @inicioVenta,SellEndDate = @finVenta," +
                                                 "DiscontinuedDate = @discontinuada,rowguid = @grid,ModifiedDate = @modificacion" +
                                                 "WHERE ProductId = @id";
                    miComando.Parameters.Clear();
                    miComando.Parameters.Add(new SqlParameter("id", producto.idProducto));
                    miComando.Parameters.Add(new SqlParameter("nombre", producto.nombre));
                    miComando.Parameters.Add(new SqlParameter("numeroProducto", producto.numeroProducto));
                    miComando.Parameters.Add(new SqlParameter("makeFlag", producto.makeFlag));
                    miComando.Parameters.Add(new SqlParameter("finishedFlag", producto.goodFlag));
                    miComando.Parameters.Add(new SqlParameter("color", producto.color));
                    miComando.Parameters.Add(new SqlParameter("stock", producto.safetyStockLevel));
                    miComando.Parameters.Add(new SqlParameter("point", producto.reorderPoint));
                    miComando.Parameters.Add(new SqlParameter("costo", producto.standartCost));
                    miComando.Parameters.Add(new SqlParameter("precioDeLista", producto.listPrice));
                    miComando.Parameters.Add(new SqlParameter("size", producto.size));
                    miComando.Parameters.Add(new SqlParameter("unidadDimension", producto.sizeUnitMeasureCode));
                    miComando.Parameters.Add(new SqlParameter("pesoUnidad", producto.weightUnitMeasureCode));
                    miComando.Parameters.Add(new SqlParameter("peso", producto.weight));
                    miComando.Parameters.Add(new SqlParameter("diasManufactura", producto.daysToManufacture));
                    miComando.Parameters.Add(new SqlParameter("linea", producto.productLine));
                    miComando.Parameters.Add(new SqlParameter("clase", producto._class));
                    miComando.Parameters.Add(new SqlParameter("estilo", producto.style));
                    miComando.Parameters.Add(new SqlParameter("subcategoria", producto.productSubcategoryID));
                    miComando.Parameters.Add(new SqlParameter("modelo", producto.productModelID));
                    miComando.Parameters.Add(new SqlParameter("inicioVenta", producto.sellStartDate));
                    miComando.Parameters.Add(new SqlParameter("finVenta", producto.sellEndDate));
                    miComando.Parameters.Add(new SqlParameter("discontinuada", producto.discontinuedDate));//
                    miComando.Parameters.Add(new SqlParameter("grid", new Guid()));//
                    miComando.Parameters.Add(new SqlParameter("modificacion", producto.modifiedDate));//
                    miComando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    miConexion.Close();
                }


            }







        }
    }
}
