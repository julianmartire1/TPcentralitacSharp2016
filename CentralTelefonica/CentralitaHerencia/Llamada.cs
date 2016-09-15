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
            sb.AppendLine("La duracion de la llamada fue: " + this._duracion);
            sb.AppendLine("El numero del destino fue de la llamada fue: " + this._nroDestino);
            sb.AppendLine("El numero de origen es: " + this._nroOrigen);

            Console.Write(sb);
        }

        public int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            return string.Compare(uno._duracion.ToString(),dos._duracion.ToString());
        }
    }
}
