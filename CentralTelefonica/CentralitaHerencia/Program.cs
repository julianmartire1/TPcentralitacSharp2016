using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main()
        {
            Centralita miCentralita = new Centralita("Telefonica");
            Local l1 = new Local("jorge", 30f, "casa", 2.65f);
            Provincial l2 = new Provincial("austaquio", 21f, "casa2", Franja.Franja_1);
            Local l3 = new Local("luis", 45f, "casa3", 1.99f);
            Provincial l4 = new Provincial(Franja.Franja_3,l2);


            miCentralita.Llamadas.Add(l1);
            miCentralita.Llamadas.Add(l2);
            miCentralita.Llamadas.Add(l3);
            miCentralita.Llamadas.Add(l4);

            miCentralita.OrdenarLlamadas();

            miCentralita.Mostrar();

            Console.ReadKey();

        }
    }
}
