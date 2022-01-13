using System;
using System.Collections.Generic;
using System.Text;

namespace Desafios_Diversos.Desafios {
    class AlturaPredio {
        public static void Executar() {
            Console.WriteLine("Informe a altura do andar:");
            var altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a número de andares:");
            var andares = int.Parse(Console.ReadLine());

            Console.WriteLine("A Altura do edifício é {0} metros", altura * andares);
        }
    }
}
