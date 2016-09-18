using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial:Llamada
    {
        protected Franja _franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        public Provincial(Franja miFranja, Llamada unaLlamada): this(unaLlamada.NroOrigen, unaLlamada.Duracion, unaLlamada.NroDestino, miFranja)            
        {

        }

        public Provincial(string origen, float duracion, string destino, Franja miFranja) : base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;                       
        }
       

        private float CalcularCosto()
        {
            float Total=0;
            if (this._franjaHoraria == Franja.Franja_1)
                Total = this._duracion * 0.99f;
            else
            {
                if (this._franjaHoraria == Franja.Franja_2)
                    Total = this._duracion * 1.25f;
                else
                    Total = this._duracion * 0.66f;
            }


            return Total;
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("La duracion de la llamada fue: " + this._duracion);
            sb.AppendLine("El numero del destino fue de la llamada fue: " + this._nroDestino);
            sb.AppendLine("El numero de origen es: " + this._nroOrigen);
            sb.AppendLine("La franja horario fue: "+this._franjaHoraria);
            sb.AppendLine("La duracion de la llamada fue: " + this.CostoLlamada);

            Console.Write(sb);
        }
    }
}
