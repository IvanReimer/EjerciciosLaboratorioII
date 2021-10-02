using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int idProducto;
        public String nombre;
        public String numeroProducto;
        public bool makeFlag;
        public bool goodFlag;
        public String color;
        public Int16 safetyStockLevel;
        public Int16 reorderPoint;
        public decimal standartCost;
        public decimal listPrice;
        public String size;
        public String sizeUnitMeasureCode;
        public String weightUnitMeasureCode;
        public decimal weight;
        public int daysToManufacture;
        public String productLine;
        public String _class;
        public String style;
        public int productSubcategoryID;
        public int productModelID;
        public DateTime sellStartDate;
        public DateTime sellEndDate;
        public DateTime discontinuedDate;
        public DateTime modifiedDate;
    }
}
