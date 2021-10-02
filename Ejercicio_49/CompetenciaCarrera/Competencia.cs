using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetenciaCarrera
{
    public class Competencia <T> where T : VehiculoDeCarrera
    {
        public enum TipoCompetencia
        {
            F1,
            Motocross
        }
        #region Atributos
        private List<T> competidores;
        private short cantidadVueltas;
        private short cantidadCompetidores;
        private TipoCompetencia tipo;
        #endregion

        #region Constructores
        private Competencia()
        {
            competidores = new List<T>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.tipo = tipo;
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        #endregion

        #region Propiedades

        public List<T> Competidores 
        {
            get
            {
                return this.competidores;
            }
            set
            {
                this.competidores = value;
            }
        }


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

        public T this[int index]
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
                sb.Append(vehiculo.MostrarDatos());
            }
            return sb.ToString();
        }
        #endregion

        #region SobreCargas

        public static bool operator ==(Competencia<T> c, T a)
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
        public static bool operator !=(Competencia<T> c, T a)
        {
            return !(c == a);
        }
        public static bool operator +(Competencia<T> c, T a)
        {
            bool correspondeAgregar = false;
            Random combustible = new Random();
            if (  !c.Contiene(a) && c.cantidadCompetidores > c.competidores.Count )
            {
                try               
                {
                    if (c == a)
                    {
                        c.competidores.Add(a);
                        a.EnCompetencia = true;
                        a.VueltasRestantes = c.CantidadVueltas;
                        a.CantidadCombustible = (short)combustible.Next(15, 100);
                        correspondeAgregar = true;
                    }
                }
                catch (CompetenciaNoDisponibleException e)
                {
                    throw new CompetenciaNoDisponibleException("Competencia incorrecta", "Competencia", "Sobrecarga +", e);
                }
            }            
            return correspondeAgregar;
        }

        public static bool operator -(Competencia<T> c, T v)
        {
            bool seEliminoVehiculoDeCarrera = false;
            foreach (T item in c.competidores)
            {
                if (v == item)
                {
                    c.competidores.Remove(item);
                    v.CantidadCombustible = 0;
                    v.EnCompetencia = false;
                    v.VueltasRestantes = 0;
                    seEliminoVehiculoDeCarrera = true;
                    break;
                }
            }
            return seEliminoVehiculoDeCarrera;
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
