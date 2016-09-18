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
                return this.CalcularGanancia(TipoLlamada.Local);
            }

        }

        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }

        }

        public float GananciaTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
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
            float retorno = 0,retorno2=0;

            switch (tipo)
            {
                case TipoLlamada.Local:

                    Local local;

                    foreach (var item in this._listaDeLLamadas)
                    {
                        if (item.GetType() == typeof(Local))
                        {
                            local = (Local)item;
                            retorno += local.CostoLlamada;
                        }
                    }

                    break;

                case TipoLlamada.Provincial:

                    Provincial prov;

                    foreach (var item in this._listaDeLLamadas)
                    {
                        if (item.GetType() == typeof(Provincial))
                        {
                            prov = (Provincial)item;
                            retorno += prov.CostoLlamada;
                        }
                    }

                    break;
                case TipoLlamada.Todas:

                    Provincial prov2;
                    Local local2;

                    foreach (var item in this._listaDeLLamadas)
                    {
                        if (item.GetType() == typeof(Provincial))
                        {
                            prov2 = (Provincial)item;
                            retorno += prov2.CostoLlamada;
                        }
                        else
                        {
                            if (item.GetType() == typeof(Local))
                            {
                                local2 = (Local)item;
                                retorno2 += local2.CostoLlamada;
                            }
                        }
                    }

                    return retorno + retorno2;

            }
            

            return retorno;
        }

        public void Mostrar()
        {
            Console.WriteLine("La razon social: "+this._razonSocial);
            Console.WriteLine("\nGanancia total: " + this.GananciaTotal);
            Console.WriteLine("Ganancia Provincial: " + this.GananciaPorProvincial);
            Console.WriteLine("Ganancia Local: " + this.GananciaPorLocal);

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
