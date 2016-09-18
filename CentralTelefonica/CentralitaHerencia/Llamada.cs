using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float _duracion;
        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }
        protected string _nroDestino;
        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }
        protected string _nroOrigen;
        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }

        }
        

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        

        public void mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nLa duracion de la llamada fue: " + this.Duracion);
            sb.AppendLine("El numero del destino fue de la llamada fue: " + this.NroDestino);
            sb.AppendLine("El numero de origen es: " + this.NroOrigen);
            sb.AppendLine();

            Console.Write(sb);
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            return string.Compare(uno._duracion.ToString(),dos._duracion.ToString());
        }
    }
}
