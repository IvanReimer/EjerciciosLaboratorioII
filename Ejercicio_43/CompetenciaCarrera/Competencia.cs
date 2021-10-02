using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetenciaCarrera
{
    public class Competencia
    {
        public enum TipoCompetencia
        {
            F1,
            Motocross
        }
        #region Atributos
        private List<VehiculoDeCarrera> competidores;
        private short cantidadVueltas;
        private short cantidadCompetidores;
        TipoCompetencia tipo;
        #endregion

        #region Constructores
        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.tipo = tipo;
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        #endregion

        #region Propiedades
        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas 
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;

            }
        }

        public TipoCompetencia Tipo 
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        
        }


        #endregion

        #region Indexadores

        public VehiculoDeCarrera this[int index]
        {
            get 
            {
                if (index < this.competidores.Count && index >= 0)
                {
                    return this.competidores[index];
                }
                else
                {
                    return null;
                }
            }
        }

        #endregion

        #region Métodos
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad Vueltas : {this.cantidadVueltas}");
            sb.AppendLine($"Cantidad Competidores : {this.cantidadCompetidores}");
            foreach (VehiculoDeCarrera vehiculo in this.competidores)
            {
                if (vehiculo is AutoF1)
                {
                    sb.Append(((AutoF1)vehiculo).MostrarDatos());
                }
                else if (vehiculo is MotoCross)
                {
                    sb.Append(((MotoCross)vehiculo).MostrarDatos());
                }

            }
            return sb.ToString();
        }
        #endregion

        #region SobreCargas

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            bool esDeTipo = false;
            switch (c.tipo)
            {
                case TipoCompetencia.F1:
                    if (a is AutoF1)
                    {
                        esDeTipo = true;
                    }
                    else
                    {
                        throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia", "Competencia", "Operador ==");
                    }
                    break;
                case TipoCompetencia.Motocross:
                    if (a is MotoCross)
                    {
                        esDeTipo = true;
                    }
                    else
                    {
                        throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia", "Competencia", "Operador ==");
                    }
                    break;
                default:
                    esDeTipo = false;
                    break;
            }
            return esDeTipo;
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }
        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            bool correspondeAgregar = false;
            Random combustible = new Random();
            if (!c.Contiene(a) && c.cantidadCompetidores > c.competidores.Count)
            {
                try
                {
                    if (c == a)
                    {
                        c.competidores.Add(a);
                        a.EnCompetencia = true;
                        a.CantidadCombustible = (short)combustible.Next(15, 100);
                        correspondeAgregar = true;
                    }
                }
                catch (CompetenciaNoDisponibleException e)
                {
                    throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "Sobrecarga +",e);
                }
            }
            return correspondeAgregar;
        }
        public bool Contiene(VehiculoDeCarrera v)
        {
            bool contieneElVehiculo = false;
            foreach (VehiculoDeCarrera vehiculo in this.competidores)
            {
                if (vehiculo == v)
                {
                    contieneElVehiculo = true;
                    break;
                }
            }
            return contieneElVehiculo;
        }

        #endregion

    }
}
