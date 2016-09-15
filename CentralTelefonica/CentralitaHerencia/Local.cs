using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local:Llamada
    {
        protected float _costo;
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Local(Llamada unaLlamada, float costo): this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, costo)    
        {
            this._costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo):base(origen,destino,duracion)
        {
            
        }
        

        private float CalcularCosto()
        {
           float Total=this._duracion * this._costo;
           return Total;
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("La duracion de la llamada fue: " + this._duracion);
            sb.AppendLine("El numero del destino fue de la llamada fue: " + this._nroDestino);
            sb.AppendLine("El numero de origen es: " + this._nroOrigen);
            sb.AppendLine("La duracion de la llamada fue: " + this.CostoLlamada);

            Console.Write(sb);
        }
    }
}
