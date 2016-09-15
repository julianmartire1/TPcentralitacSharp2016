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
                throw new System.NotImplementedException();
            }

        }

        public float GananciaTotal
        {
            get
            {
                throw new System.NotImplementedException();
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
            
        }

        public Centralita(string nombreEmpresa)
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
        }

        public void OrdenarLlamadas()
        {
            
        }
    }
}
