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
            Local l1 = new Local("casa", 30f, "jorge", 2.65f);
            Provincial l2 = new Provincial("casa2", 21f, "austaquio", Franja.Franja_1);
            Local l3 = new Local("casa3", 45f, "luis", 1.99f);
            Provincial l4 = new Provincial(Franja.Franja_3,l2);

            Console.WriteLine("Mostrando las Llamas desordenadas");

            miCentralita.Llamadas.Add(l1);
            miCentralita.Llamadas.Add(l2);
            miCentralita.Llamadas.Add(l3);
            miCentralita.Llamadas.Add(l4);

            miCentralita.Mostrar();

            Console.ReadKey();
            Console.WriteLine("Mostrando las Llamas ordenadas");

            miCentralita.OrdenarLlamadas();
            miCentralita.Mostrar();
            

            Console.ReadKey();

        }
    }
}
