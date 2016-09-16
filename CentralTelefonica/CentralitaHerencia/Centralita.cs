using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> _listaDeLLamadas;
        protected string _razonSocial;

        public float GananciaPorLocal
        {
            get
            {
                throw new System.NotImplementedException();
            }

        }

        public float GananciaPorProvincial
        {
            get
            {
                return 1;
            }

        }

        public float GananciaTotal
        {
            get
            {
                return 1;
            }

        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLLamadas;
            }

        }
        
        public Centralita()
        {
            _listaDeLLamadas =new List<Llamada>();
        }

        public Centralita(string nombreEmpresa):this()
        {
            this._razonSocial = nombreEmpresa;
        }

        

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float Ganancia=0;

            if (tipo == TipoLlamada.Local)
                Ganancia = this.GananciaPorLocal;            
            else            
                if (tipo == TipoLlamada.Provincial)
                    Ganancia = this.GananciaPorProvincial;                
                else
                    Ganancia = this.GananciaTotal;
            

            return Ganancia;
        }

        public void Mostrar()
        {
            Console.WriteLine("La razon social: "+this._razonSocial);
            /*Console.WriteLine("\nGanancia total: " + this.GananciaTotal);
            Console.WriteLine("Ganancia total: " + this.GananciaPorProvincial);
            Console.WriteLine("Ganancia total: " + this.GananciaPorLocal);*/

            foreach (Llamada item in this._listaDeLLamadas)
            {
                item.mostrar();
            }
            

        }

        public void OrdenarLlamadas()
        {
            this._listaDeLLamadas.Sort(Llamada.OrdenarPorDuracion);            
        }
    }
}
